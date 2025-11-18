using System.Collections.Generic;
using Newtonsoft.Json;

namespace DeepSound.Helpers.Model
{
    public class FeaturedAlbumsObject
    {
        [JsonProperty("albums")]
        public List<FeaturedAlbumItem> Albums { get; set; }
    }

    public class FeaturedAlbumItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
