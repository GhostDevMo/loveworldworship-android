using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.ViewPager2.Widget;
using Bumptech.Glide;
using DeepSound.Helpers.Model;
using Google.Android.Material.Tabs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeepSound.Activities.Tabbes.HomePages
{
    public class FeaturedAlbumsFragment : Fragment
    {
        private ViewPager2 featuredAlbumsViewPager;
        private List<FeaturedAlbumItem> featuredAlbums = new List<FeaturedAlbumItem>();
        private Handler autoScrollHandler;
        private Java.Lang.Runnable autoScrollRunnable;

        private readonly string FeaturedAlbumsEndpoint = "https://loveworldworship.com/worship/api/featured_albums.json";

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment_featured_albums, container, false);

            featuredAlbumsViewPager = view.FindViewById<ViewPager2>(Resource.Id.featuredAlbumsViewPager);
            autoScrollHandler = new Handler(Looper.MainLooper);

            LoadFeaturedAlbums();

            return view;
        }

        private async void LoadFeaturedAlbums()
        {
            try
            {
                var client = new HttpClient();
                string json = await client.GetStringAsync("https://loveworldworship.com/worship/api/featured_albums.json");

                var data = JsonConvert.DeserializeObject<FeaturedAlbumsObject>(json);

                if (data?.Albums == null || data.Albums.Count == 0)
                {
                    Console.WriteLine("No featured albums found — skipping display.");
                    return;
                }

                // ✅ Continue displaying albums here (RecyclerView, adapter, etc.)
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading featured albums: " + ex.Message);
            }
        }

        public override void OnDestroyView()
        {
            base.OnDestroyView();
            autoScrollHandler?.RemoveCallbacks(autoScrollRunnable);
        }
    }

    public class FeaturedAlbumItem
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string LinkUrl { get; set; }
    }

    public class FeaturedAlbumsAdapter : AndroidX.RecyclerView.Widget.RecyclerView.Adapter
    {
        private readonly Context context;
        private readonly List<FeaturedAlbumItem> albums;

        public FeaturedAlbumsAdapter(Context context, List<FeaturedAlbumItem> albums)
        {
            this.context = context;
            this.albums = albums;
        }

        public override int ItemCount => albums.Count;

        public override AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_featured_album, parent, false);
            return new FeaturedAlbumViewHolder(view);
        }

        public override void OnBindViewHolder(AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder holder, int position)
        {
            var vh = holder as FeaturedAlbumViewHolder;
            var item = albums[position];

            vh.Title.Text = item.Title;
            Glide.With(context).Load(item.ImageUrl).Into(vh.Cover);

            vh.ItemView.Click += (s, e) =>
            {
                if (!string.IsNullOrEmpty(item.LinkUrl))
                {
                    var intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(item.LinkUrl));
                    context.StartActivity(intent);
                }
            };
        }

        private class FeaturedAlbumViewHolder : AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder
        {
            public ImageView Cover { get; }
            public TextView Title { get; }

            public FeaturedAlbumViewHolder(View itemView) : base(itemView)
            {
                Cover = itemView.FindViewById<ImageView>(Resource.Id.albumCover);
                Title = itemView.FindViewById<TextView>(Resource.Id.albumTitle);
            }
        }
    }
}
