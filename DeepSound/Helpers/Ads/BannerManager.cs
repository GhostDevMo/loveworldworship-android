using Android.Content;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Android.Graphics;
using Bumptech.Glide;

namespace DeepSound.Helpers.Ads
{
    public static class BannerManager
    {
        private static readonly string Endpoint = "https://loveworldworship.com/worship/api/ad_banners.json";

        public class AdBannerItem
        {
            public string ImageUrl { get; set; }
            public string LinkUrl { get; set; }
            public string Text { get; set; }
        }

        public static async Task LoadBannerAsync(Context context, FrameLayout container)
        {
            try
            {
                using var http = new HttpClient();
                string json = await http.GetStringAsync(Endpoint);
                var ads = JsonConvert.DeserializeObject<List<AdBannerItem>>(json);

                if (ads == null || ads.Count == 0)
                    return;

                // Use the first ad for now
                var ad = ads[0];

                // Create a simple ImageView banner
                var image = new ImageView(context)
                {
                    LayoutParameters = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, 400)
                };
                image.SetScaleType(ImageView.ScaleType.CenterCrop);

                Glide.With(context)
                    .Load(ad.ImageUrl)
                    .Into(image);

                image.Click += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(ad.LinkUrl))
                    {
                        var intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(ad.LinkUrl));
                        context.StartActivity(intent);
                    }
                };

                container.AddView(image);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[BannerManager] Error: {ex.Message}");
            }
        }
    }
}
