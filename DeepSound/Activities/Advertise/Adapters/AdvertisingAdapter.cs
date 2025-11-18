using Android.App;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Bumptech.Glide;
using Bumptech.Glide.Request;
using DeepSound.Helpers.CacheLoaders;
using DeepSound.Helpers.Fonts;
using DeepSound.Helpers.Utils;
using DeepSoundClient.Classes.Advertise;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using IList = System.Collections.IList;

namespace DeepSound.Activities.Advertise.Adapters
{
    public class AdvertisingAdapter : RecyclerView.Adapter, ListPreloader.IPreloadModelProvider
    {
        public event EventHandler<AdvertisingAdapterClickEventArgs> EditItemClick;
        public event EventHandler<AdvertisingAdapterClickEventArgs> DeleteItemClick;
        public event EventHandler<AdvertisingAdapterClickEventArgs> ItemClick;
        public event EventHandler<AdvertisingAdapterClickEventArgs> ItemLongClick;
        private readonly Activity ActivityContext;
        public ObservableCollection<AdvertiseDataObject> AdsList = new ObservableCollection<AdvertiseDataObject>();

        public AdvertisingAdapter(Activity context)
        {
            try
            {
                ActivityContext = context;
                HasStableIds = true;
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            try
            {
                //Setup your layout here >> Style_AdvertisingView
                View itemView = LayoutInflater.From(parent.Context)?.Inflate(Resource.Layout.Style_AdvertisingView, parent, false);
                var vh = new AdvertisingAdapterViewHolder(itemView, EditClick, DeleteClick, Click, LongClick);
                return vh;
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
                return null;
            }
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            try
            {
                if (viewHolder is AdvertisingAdapterViewHolder holder)
                {
                    var item = AdsList[position];
                    if (item != null)
                    {
                        if (item.AdType == "audio")
                            GlideImageLoader.LoadImage(ActivityContext, "Audio_File", holder.Image, ImageStyle.RoundedCrop, ImagePlaceholders.Drawable);
                        else
                            GlideImageLoader.LoadImage(ActivityContext, item.Media, holder.Image, ImageStyle.RoundedCrop, ImagePlaceholders.Drawable);

                        holder.Name.Text = Methods.FunString.DecodeString(item.Name);

                        if (item.Posted != null)
                            holder.Time.Text = Methods.Time.TimeAgo(item.Posted.Value, false);

                        if (item.Status == 1)
                            holder.Status.Text = ActivityContext.GetText(Resource.String.Lbl_Status) + " : " + ActivityContext.GetText(Resource.String.Lbl_Active);
                        else
                            holder.Status.Text = ActivityContext.GetText(Resource.String.Lbl_Status) + " : " + ActivityContext.GetText(Resource.String.Lbl_Inactive);
                    }
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }


        public override int ItemCount
        {
            get
            {
                if (AdsList != null)
                {
                    return AdsList.Count;
                }
                else
                {
                    return 0;
                }
            }
        }

        public AdvertiseDataObject GetItem(int position)
        {
            return AdsList[position];
        }

        public override long GetItemId(int position)
        {
            try
            {
                return position;
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
                return 0;
            }
        }

        public override int GetItemViewType(int position)
        {
            try
            {
                return position;
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
                return 0;
            }
        }

        private void EditClick(AdvertisingAdapterClickEventArgs args) => EditItemClick?.Invoke(this, args);
        private void DeleteClick(AdvertisingAdapterClickEventArgs args) => DeleteItemClick?.Invoke(this, args);
        void Click(AdvertisingAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void LongClick(AdvertisingAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

        public IList GetPreloadItems(int p0)
        {
            try
            {
                var d = new List<string>();
                var item = AdsList[p0];

                if (item == null)
                    return Collections.SingletonList(p0);

                if (item.Media != "")
                {
                    d.Add(item.Media);
                    return d;
                }

                return d;
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
                return Collections.SingletonList(p0);
            }
        }

        public RequestBuilder GetPreloadRequestBuilder(Java.Lang.Object p0)
        {
            return Glide.With(ActivityContext?.BaseContext).Load(p0.ToString())
                .Apply(new RequestOptions().CircleCrop());
        }
    }

    public class AdvertisingAdapterViewHolder : RecyclerView.ViewHolder
    {
        #region Variables Basic

        public View MainView { get; private set; }

        public ImageView Image { get; private set; }
        public TextView Name { get; private set; }
        public TextView Edit { get; private set; }
        public TextView Delete { get; private set; }
        public TextView Time { get; private set; }
        public TextView Status { get; private set; }

        #endregion

        public AdvertisingAdapterViewHolder(View itemView, Action<AdvertisingAdapterClickEventArgs> editClickListener, Action<AdvertisingAdapterClickEventArgs> deleteClickListener, Action<AdvertisingAdapterClickEventArgs> clickListener, Action<AdvertisingAdapterClickEventArgs> longClickListener) : base(itemView)
        {
            try
            {
                MainView = itemView;

                //Get values
                Image = MainView.FindViewById<ImageView>(Resource.Id.image);
                Name = MainView.FindViewById<TextView>(Resource.Id.name);
                Edit = MainView.FindViewById<TextView>(Resource.Id.edit);
                Delete = MainView.FindViewById<TextView>(Resource.Id.delete);
                Time = MainView.FindViewById<TextView>(Resource.Id.time);
                Status = MainView.FindViewById<TextView>(Resource.Id.status);

                FontUtils.SetTextViewIcon(FontsIconFrameWork.FontAwesomeRegular, Edit, FontAwesomeIcon.Edit);
                FontUtils.SetTextViewIcon(FontsIconFrameWork.FontAwesomeRegular, Delete, FontAwesomeIcon.TrashAlt);

                //Event
                Edit.Click += (sender, e) => editClickListener(new AdvertisingAdapterClickEventArgs { View = itemView, Position = BindingAdapterPosition });
                Delete.Click += (sender, e) => deleteClickListener(new AdvertisingAdapterClickEventArgs { View = itemView, Position = BindingAdapterPosition });
                itemView.Click += (sender, e) => clickListener(new AdvertisingAdapterClickEventArgs { View = itemView, Position = BindingAdapterPosition });
                itemView.LongClick += (sender, e) => longClickListener(new AdvertisingAdapterClickEventArgs { View = itemView, Position = BindingAdapterPosition });
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }
    }

    public class AdvertisingAdapterClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}