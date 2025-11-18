using Android.Content;
using AndroidX.RecyclerView.Widget;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeepSound.Helpers
{
    public static class FeaturedAlbumsManager
    {
        private const string Endpoint = "https://loveworldworship.com/worship/api/featured_albums.json";

        public static async Task LoadAsync(Context context, RecyclerView recyclerView)
        {
            try
            {
                using var http = new HttpClient();
                string json = await http.GetStringAsync(Endpoint);
                var albums = JsonConvert.DeserializeObject<List<DeepSound.Adapters.FeaturedAlbumItem>>(json);

                if (albums == null || albums.Count == 0)
                    return;

                var adapter = new DeepSound.Adapters.FeaturedAlbumsAdapter(context, albums);
                recyclerView.SetLayoutManager(new LinearLayoutManager(context, LinearLayoutManager.Horizontal, false));
                recyclerView.SetAdapter(adapter);
            }
            catch (System.Exception ex)
            {
                Android.Util.Log.Error("FeaturedAlbums", ex.Message);
            }
        }
    }
}
