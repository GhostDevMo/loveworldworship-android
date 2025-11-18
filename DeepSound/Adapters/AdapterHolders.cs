using Android.App;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Com.Google.Android.Gms.Ads.Admanager;
using DeepSound.Helpers.Ads;
using DeepSound.Helpers.Utils;
using System;
using System.Linq;

namespace DeepSound.Adapters
{
    public class AdapterHolders
    {
        public class AdsAdapterViewHolder : RecyclerView.ViewHolder
        {
            #region Variables Basic

            public View MainView { get; private set; }
            public TemplateView MianAlert { get; private set; }
            public AdManagerAdView AdManagerAdView { get; private set; }
            public LinearLayout NativeAdLayout { get; private set; }

            #endregion

            public AdsAdapterViewHolder(View itemView, AdsModelType modelType, Activity activity) : base(itemView)
            {
                try
                {
                    MainView = itemView;

                    switch (modelType)
                    {
                        case AdsModelType.AdMob1 or AdsModelType.AdMob2 or AdsModelType.AdMob5:
                            MianAlert = MainView.FindViewById<TemplateView>(Resource.Id.my_template);
                            MianAlert.Visibility = ViewStates.Gone;

                            AdsGoogle.Ad_AdMobNative(activity, MianAlert);
                            break;
                        case AdsModelType.AdMob3:
                            AdManagerAdView = MainView.FindViewById<AdManagerAdView>(Resource.Id.multiple_ad_sizes_view);
                            AdManagerAdView.Visibility = ViewStates.Gone;
                            AdsGoogle.InitAdManagerAdView(AdManagerAdView);
                            break;
                        case AdsModelType.FbAdNative:
                            {
                                NativeAdLayout = itemView.FindViewById<LinearLayout>(Resource.Id.native_ad_container);
                                NativeAdLayout.Visibility = ViewStates.Gone;

                                if (AdsFacebook.MAdItems.Count > 0)
                                {
                                    var ad = AdsFacebook.MAdItems.FirstOrDefault();
                                    AdsFacebook.InitNative(activity, NativeAdLayout, ad);
                                    AdsFacebook.MAdItems.Remove(ad);
                                }
                                else
                                    AdsFacebook.InitNative(activity, NativeAdLayout, null);

                                AdsFacebook.BindAdFb(activity);
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Methods.DisplayReportResultTrack(e);
                }
            }
        }

    }

    public enum AdsModelType
    {
        AdMob1 = 1, AdMob2 = 2, AdMob3 = 3, AdMob5 = 5, FbAdNative = 10
    }
}