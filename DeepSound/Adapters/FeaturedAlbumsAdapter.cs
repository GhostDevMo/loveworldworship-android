using Android.Content;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Bumptech.Glide;
using System.Collections.Generic;

namespace DeepSound.Adapters
{
    public class FeaturedAlbumsAdapter : RecyclerView.Adapter
    {
        private readonly Context context;
        private readonly List<FeaturedAlbumItem> albums;

        public FeaturedAlbumsAdapter(Context ctx, List<FeaturedAlbumItem> list)
        {
            context = ctx;
            albums = list;
        }

        public override int ItemCount => albums.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is FeaturedAlbumsViewHolder vh)
            {
                var item = albums[position];
                vh.Title.Text = item.Title;

                Glide.With(context)
                    .Load(item.ImageUrl)
                    .Placeholder(Resource.Drawable.cast_album_art_placeholder)
                    .Error(Resource.Drawable.cast_album_art_placeholder)
                    .Into(vh.Cover);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.From(parent.Context)
                .Inflate(Resource.Layout.Item_FeaturedAlbum, parent, false);
            return new FeaturedAlbumsViewHolder(itemView);
        }

        public class FeaturedAlbumsViewHolder : RecyclerView.ViewHolder
        {
            public ImageView Cover { get; }
            public TextView Title { get; }

            public FeaturedAlbumsViewHolder(View itemView) : base(itemView)
            {
                Cover = itemView.FindViewById<ImageView>(Resource.Id.albumCover);
                Title = itemView.FindViewById<TextView>(Resource.Id.albumTitle);
            }
        }
    }

    public class FeaturedAlbumItem
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}
