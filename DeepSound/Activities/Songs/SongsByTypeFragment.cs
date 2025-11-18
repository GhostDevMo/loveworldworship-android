using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AndroidX.SwipeRefreshLayout.Widget;
using Bumptech.Glide.Util;
using Com.Facebook.Ads;
using DeepSound.Activities.Songs.Adapters;
using DeepSound.Activities.Tabbes;
using DeepSound.Helpers.Ads;
using DeepSound.Helpers.Controller;
using DeepSound.Helpers.MediaPlayerController;
using DeepSound.Helpers.Model;
using DeepSound.Helpers.ShimmerUtils;
using DeepSound.Helpers.Utils;
using DeepSound.Library.Anjo.IntegrationRecyclerView;
using DeepSoundClient.Classes.Global;
using DeepSoundClient.Classes.User;
using DeepSoundClient.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace DeepSound.Activities.Songs
{
    public class SongsByTypeFragment : Fragment
    {
        #region Variables Basic

        public static SongsByTypeFragment Instance;
        public RowSoundAdapter MAdapter;
        private HomeActivity GlobalContext;
        private SwipeRefreshLayout SwipeRefreshLayout;
        private RecyclerView MRecycler;
        private LinearLayoutManager LayoutManager;
        private ViewStub EmptyStateLayout, ShimmerPageLayout;
        private View Inflated, InflatedShimmer;
        private TemplateShimmerInflater ShimmerInflater;
        private string SongsType, UserId;
        private RecyclerViewOnScrollListener MainScrollEvent;
        private bool MIsVisibleToUser;
        private AdView BannerAd;
        private PopupFilterList PopupFilterList;

        #endregion

        #region General

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            HasOptionsMenu = true;
            // Create your fragment here
            GlobalContext = (HomeActivity)Activity;
            Instance = this;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            try
            {
                View view = inflater.Inflate(Resource.Layout.MainFragmentLayout, container, false);
                return view;
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
                return null;
            }
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            try
            {
                base.OnViewCreated(view, savedInstanceState);

                SongsType = Arguments?.GetString("SongsType") ?? "";
                UserId = Arguments?.GetString("UserId") ?? "";

                InitComponent(view);
                InitShimmer(view);
                SetRecyclerViewAdapters();

                PopupFilterList = new PopupFilterList(view, Activity, MAdapter);

                AdsGoogle.Ad_Interstitial(Activity);
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }


        public override void SetMenuVisibility(bool menuVisible)
        {
            try
            {
                base.SetMenuVisibility(menuVisible);
                MIsVisibleToUser = menuVisible;
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public override void OnResume()
        {
            try
            {
                base.OnResume();
                Instance = this;
                if (IsResumed && MIsVisibleToUser)
                {
                    GetSongsByType();
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public override void OnLowMemory()
        {
            try
            {
                GC.Collect(GC.MaxGeneration);
                base.OnLowMemory();
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public override void OnDestroy()
        {
            try
            {
                Instance = null;
                BannerAd?.Destroy();
                base.OnDestroy();
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

        #region Functions

        private void InitComponent(View view)
        {
            try
            {
                MRecycler = view.FindViewById<RecyclerView>(Resource.Id.recyler);
                EmptyStateLayout = view.FindViewById<ViewStub>(Resource.Id.viewStub);

                SwipeRefreshLayout = view.FindViewById<SwipeRefreshLayout>(Resource.Id.swipeRefreshLayout);
                SwipeRefreshLayout.SetColorSchemeResources(Android.Resource.Color.HoloBlueLight, Android.Resource.Color.HoloGreenLight, Android.Resource.Color.HoloOrangeLight, Android.Resource.Color.HoloRedLight);
                SwipeRefreshLayout.Refreshing = true;
                SwipeRefreshLayout.Enabled = true;
                SwipeRefreshLayout.SetProgressBackgroundColorSchemeColor(DeepSoundTools.IsTabDark() ? Color.ParseColor("#424242") : Color.ParseColor("#f7f7f7"));
                //SwipeRefreshLayout.Refresh += SwipeRefreshLayoutOnRefresh;

                LinearLayout adContainer = view.FindViewById<LinearLayout>(Resource.Id.bannerContainer);
                if (AppSettings.ShowFbBannerAds)
                    BannerAd = AdsFacebook.InitAdView(Activity, adContainer, MRecycler);
                else if (AppSettings.ShowAppLovinBannerAds)
                    AdsAppLovin.InitBannerAd(Activity, adContainer, MRecycler);
                else
                    AdsGoogle.InitBannerAdView(Activity, adContainer, MRecycler);
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        private void InitShimmer(View view)
        {
            try
            {
                ShimmerPageLayout = view.FindViewById<ViewStub>(Resource.Id.viewStubShimmer);
                InflatedShimmer ??= ShimmerPageLayout.Inflate();

                ShimmerInflater = new TemplateShimmerInflater();
                ShimmerInflater.InflateLayout(Activity, InflatedShimmer, ShimmerTemplateStyle.SongRowTemplate);
                ShimmerInflater.Show();
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }
        private void InitToolbar(View view)
        {
            try
            {
                var toolbar = view.FindViewById<Toolbar>(Resource.Id.toolbar);

                switch (SongsType)
                {
                    case "Popular":
                        {
                            GlobalContext.SetToolBar(toolbar, Context.GetString(Resource.String.Lbl_Popular_Title));
                            break;
                        }
                    case "RecentlyPlayed":
                        {
                            GlobalContext.SetToolBar(toolbar, Context.GetString(Resource.String.Lbl_RecentlyPlayed));
                            break;
                        }
                    case "NewReleases":
                        {
                            GlobalContext.SetToolBar(toolbar, Context.GetString(Resource.String.Lbl_LatestSongs_Title));
                            break;
                        }
                    case "BrowseTopSongs":
                        {
                            GlobalContext.SetToolBar(toolbar, Context.GetString(Resource.String.Lbl_TopSongs_Title));
                            break;
                        }
                    default:
                        GlobalContext.SetToolBar(toolbar, SongsType);
                        break;
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        private void SetRecyclerViewAdapters()
        {
            try
            {
                MAdapter = new RowSoundAdapter(Activity, "SongsByTypeFragment") { SoundsList = new ObservableCollection<SoundDataObject>() };
                MAdapter.ItemClick += MAdapterItemClick;
                MRecycler.SetItemAnimator(null);
                LayoutManager = new LinearLayoutManager(Activity);
                MRecycler.SetLayoutManager(LayoutManager);
                MRecycler.HasFixedSize = true;
                MRecycler.SetItemViewCacheSize(10);
                MRecycler.GetLayoutManager().ItemPrefetchEnabled = true;
                var sizeProvider = new FixedPreloadSizeProvider(10, 10);
                var preLoader = new RecyclerViewPreloader<SoundDataObject>(Activity, MAdapter, sizeProvider, 10);
                MRecycler.AddOnScrollListener(preLoader);
                MRecycler.SetAdapter(MAdapter);

                RecyclerViewOnScrollListener xamarinRecyclerViewOnScrollListener = new RecyclerViewOnScrollListener(LayoutManager);
                MainScrollEvent = xamarinRecyclerViewOnScrollListener;
                MainScrollEvent.LoadMoreEvent += MainScrollEventOnLoadMoreEvent;
                MRecycler.AddOnScrollListener(xamarinRecyclerViewOnScrollListener);
                MainScrollEvent.IsLoading = false;
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

        #region Event

        //Start Play Sound 
        private void MAdapterItemClick(object sender, RowSoundAdapterClickEventArgs e)
        {
            try
            {
                var item = MAdapter.GetItem(e.Position);
                if (item != null)
                {
                    if (item.IsPlay)
                    {
                        item.IsPlay = false;

                        var index = MAdapter.SoundsList.IndexOf(item);
                        MAdapter.NotifyItemChanged(index, "playerAction");

                        GlobalContext?.SoundController.StartOrPausePlayer();
                    }
                    else
                    {
                        var list = MAdapter.SoundsList.Where(sound => sound.IsPlay).ToList();
                        if (list.Count > 0)
                        {
                            foreach (var all in list)
                            {
                                all.IsPlay = false;

                                var index = MAdapter.SoundsList.IndexOf(all);
                                MAdapter.NotifyItemChanged(index, "playerAction");
                            }
                        }

                        item.IsPlay = true;
                        MAdapter.NotifyItemChanged(e.Position, "playerAction");

                        Constant.PlayPos = e.Position;
                        GlobalContext?.SoundController?.StartPlaySound(item, MAdapter.SoundsList, MAdapter);
                    }
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        //Scroll
        private void MainScrollEventOnLoadMoreEvent(object sender, EventArgs e)
        {
            try
            {
                //Code get last id where LoadMore >>
                var item = MAdapter.SoundsList.LastOrDefault(a => a.TypeView != "Ads");
                if (item != null && !string.IsNullOrEmpty(item.Id.ToString()) && !MainScrollEvent.IsLoading)
                {
                    if (!Methods.CheckConnectivity())
                        Toast.MakeText(Activity, Activity.GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short)?.Show();
                    else
                    {
                        switch (SongsType)
                        {
                            case "Popular":
                                {
                                    //PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => LoadPopular(item.Id.ToString()) });
                                    break;
                                }
                            case "RecentlyPlayed":
                                {
                                    PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => LoadRecentlyPlayed(item.Id.ToString()) });
                                    break;
                                }
                            case "NewReleases":
                                {
                                    PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => LoadNewReleases(item.Id.ToString()) });
                                    break;
                                }
                            case "BrowseTopSongs":
                                {
                                    PollyController.RunRetryPolicyFunction(new List<Func<Task>> { () => LoadTopSongs(item.Id.ToString()) });
                                    break;
                                }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        #endregion

        #region Load Data Soungs

        private void GetSongsByType()
        {
            try
            {
                if (Methods.CheckConnectivity())
                {
                    ShimmerInflater?.Show();

                    switch (SongsType)
                    {
                        case "Popular":
                            {
                                if (GlobalContext?.HomeFragment?.LatestHomeTab?.PopularSoundAdapter?.SoundsList?.Count > 0)
                                {
                                    foreach (var item in GlobalContext.HomeFragment.LatestHomeTab.PopularSoundAdapter.SoundsList)
                                    {
                                        var check = MAdapter.SoundsList.FirstOrDefault(a => a.Id == item.Id);
                                        if (check == null)
                                        {
                                            MAdapter.SoundsList.Add(item);

                                            if (MAdapter.SoundsList.Count % AppSettings.ShowAdNativeCount == 0)
                                            {
                                                MAdapter.SoundsList.Add(new SoundDataObject()
                                                {
                                                    TypeView = "Ads"
                                                });
                                            }
                                        }
                                    }
                                    MAdapter.NotifyDataSetChanged();
                                }
                                break;
                            }
                        case "RecentlyPlayed":
                            {
                                if (GlobalContext?.HomeFragment?.LatestHomeTab?.RecentlyPlayedSoundAdapter?.SoundsList?.Count > 0)
                                {
                                    foreach (var item in GlobalContext.HomeFragment.LatestHomeTab.RecentlyPlayedSoundAdapter.SoundsList)
                                    {
                                        var check = MAdapter.SoundsList.FirstOrDefault(a => a.Id == item.Id);
                                        if (check == null)
                                        {
                                            MAdapter.SoundsList.Add(item);

                                            if (MAdapter.SoundsList.Count % AppSettings.ShowAdNativeCount == 0)
                                            {
                                                MAdapter.SoundsList.Add(new SoundDataObject()
                                                {
                                                    TypeView = "Ads"
                                                });
                                            }
                                        }
                                    }
                                    MAdapter.NotifyDataSetChanged();
                                }
                                break;
                            }
                        case "NewReleases":
                            {
                                if (GlobalContext?.HomeFragment?.LatestHomeTab?.NewReleasesSoundAdapter?.SoundsList?.Count > 0)
                                {
                                    foreach (var item in GlobalContext.HomeFragment.LatestHomeTab.NewReleasesSoundAdapter.SoundsList)
                                    {
                                        var check = MAdapter.SoundsList.FirstOrDefault(a => a.Id == item.Id);
                                        if (check == null)
                                        {
                                            MAdapter.SoundsList.Add(item);

                                            if (MAdapter.SoundsList.Count % AppSettings.ShowAdNativeCount == 0)
                                            {
                                                MAdapter.SoundsList.Add(new SoundDataObject()
                                                {
                                                    TypeView = "Ads"
                                                });
                                            }
                                        }
                                    }
                                    MAdapter.NotifyDataSetChanged();
                                }
                                break;
                            }
                        case "BrowseTopSongs":
                            {
                                if (GlobalContext?.HomeFragment?.LatestHomeTab?.TopSongsSoundAdapter?.SoundsList?.Count > 0)
                                {
                                    foreach (var item in GlobalContext.HomeFragment.LatestHomeTab.TopSongsSoundAdapter.SoundsList)
                                    {
                                        var check = MAdapter.SoundsList.FirstOrDefault(a => a.Id == item.Id);
                                        if (check == null)
                                        {
                                            MAdapter.SoundsList.Add(item);

                                            if (MAdapter.SoundsList.Count % AppSettings.ShowAdNativeCount == 0)
                                            {
                                                MAdapter.SoundsList.Add(new SoundDataObject()
                                                {
                                                    TypeView = "Ads"
                                                });
                                            }
                                        }
                                    }
                                    MAdapter.NotifyDataSetChanged();
                                }
                                break;
                            }
                    }

                    Activity?.RunOnUiThread(ShowEmptyPage);
                }
                else
                {
                    Inflated = EmptyStateLayout.Inflate();
                    EmptyStateInflater x = new EmptyStateInflater();
                    x.InflateLayout(Inflated, EmptyStateInflater.Type.NoConnection);
                    if (!x.EmptyStateButton.HasOnClickListeners)
                    {
                        x.EmptyStateButton.Click += null;
                        x.EmptyStateButton.Click += EmptyStateButtonOnClick;
                    }

                    Toast.MakeText(Context, GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short)?.Show();
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        private async Task LoadTopSongs(string offset = "0")
        {
            if (MainScrollEvent.IsLoading)
                return;

            if (Methods.CheckConnectivity())
            {
                MainScrollEvent.IsLoading = true;

                int countList = MAdapter.SoundsList.Count;
                var (apiStatus, respond) = await RequestsAsync.Common.TopSongsAsync("15", offset);
                if (apiStatus == 200)
                {
                    if (respond is GetSoundDataObject result)
                    {
                        var respondList = result.Data?.Count;
                        if (respondList > 0)
                        {
                            result.Data = DeepSoundTools.ListFilter(result.Data);

                            foreach (var item in from item in result.Data let check = MAdapter.SoundsList.FirstOrDefault(a => a.Id == item.Id) where check == null select item)
                            {
                                MAdapter.SoundsList.Add(item);

                                if (MAdapter.SoundsList.Count % AppSettings.ShowAdNativeCount == 0)
                                {
                                    MAdapter.SoundsList.Add(new SoundDataObject()
                                    {
                                        TypeView = "Ads"
                                    });
                                }
                            }

                            if (countList > 0)
                            {
                                Activity?.RunOnUiThread(() => { MAdapter.NotifyItemRangeInserted(countList, MAdapter.SoundsList.Count - countList); });
                            }
                            else
                            {
                                Activity?.RunOnUiThread(() => { MAdapter.NotifyDataSetChanged(); });
                            }
                        }
                        else
                        {
                            if (MAdapter.SoundsList.Count > 10 && !MRecycler.CanScrollVertically(1))
                                Toast.MakeText(Context, Context.GetText(Resource.String.Lbl_NoMoreRecentlyPlayed), ToastLength.Short)?.Show();
                        }
                    }
                }
                else
                {
                    MainScrollEvent.IsLoading = false;
                    Methods.DisplayReportResult(Activity, respond);
                }

                Activity?.RunOnUiThread(ShowEmptyPage);
            }
            else
            {
                Inflated = EmptyStateLayout.Inflate();
                EmptyStateInflater x = new EmptyStateInflater();
                x.InflateLayout(Inflated, EmptyStateInflater.Type.NoConnection);
                if (!x.EmptyStateButton.HasOnClickListeners)
                {
                    x.EmptyStateButton.Click += null;
                    x.EmptyStateButton.Click += EmptyStateButtonOnClick;
                }

                Toast.MakeText(Context, GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short)?.Show();
                MainScrollEvent.IsLoading = false;
            }
            MainScrollEvent.IsLoading = false;
        }

        private async Task LoadNewReleases(string offset = "0")
        {
            if (!UserDetails.IsLogin)
                return;

            if (MainScrollEvent.IsLoading)
                return;

            if (Methods.CheckConnectivity())
            {
                MainScrollEvent.IsLoading = true;

                int countList = MAdapter.SoundsList.Count;
                var (apiStatus, respond) = await RequestsAsync.Common.GetNewReleasesAsync("15", offset);
                if (apiStatus == 200)
                {
                    if (respond is GetSoundDataObject result)
                    {
                        var respondList = result.Data?.Count;
                        if (respondList > 0)
                        {
                            result.Data = DeepSoundTools.ListFilter(result.Data);

                            foreach (var item in from item in result.Data let check = MAdapter.SoundsList.FirstOrDefault(a => a.Id == item.Id) where check == null select item)
                            {
                                MAdapter.SoundsList.Add(item);

                                if (MAdapter.SoundsList.Count % AppSettings.ShowAdNativeCount == 0)
                                {
                                    MAdapter.SoundsList.Add(new SoundDataObject()
                                    {
                                        TypeView = "Ads"
                                    });
                                }
                            }

                            if (countList > 0)
                            {
                                Activity?.RunOnUiThread(() => { MAdapter.NotifyItemRangeInserted(countList, MAdapter.SoundsList.Count - countList); });
                            }
                            else
                            {
                                Activity?.RunOnUiThread(() => { MAdapter.NotifyDataSetChanged(); });
                            }
                        }
                        else
                        {
                            if (MAdapter.SoundsList.Count > 10 && !MRecycler.CanScrollVertically(1))
                                Toast.MakeText(Context, Context.GetText(Resource.String.Lbl_NoMoreRecentlyPlayed), ToastLength.Short)?.Show();
                        }
                    }
                }
                else
                {
                    MainScrollEvent.IsLoading = false;
                    Methods.DisplayReportResult(Activity, respond);
                }

                Activity?.RunOnUiThread(ShowEmptyPage);
            }
            else
            {
                Inflated = EmptyStateLayout.Inflate();
                EmptyStateInflater x = new EmptyStateInflater();
                x.InflateLayout(Inflated, EmptyStateInflater.Type.NoConnection);
                if (!x.EmptyStateButton.HasOnClickListeners)
                {
                    x.EmptyStateButton.Click += null;
                    x.EmptyStateButton.Click += EmptyStateButtonOnClick;
                }

                Toast.MakeText(Context, GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short)?.Show();
                MainScrollEvent.IsLoading = false;
            }
            MainScrollEvent.IsLoading = false;
        }

        private async Task LoadRecentlyPlayed(string offset = "0")
        {
            if (MainScrollEvent.IsLoading)
                return;

            if (Methods.CheckConnectivity())
            {
                MainScrollEvent.IsLoading = true;

                int countList = MAdapter.SoundsList.Count;
                var (apiStatus, respond) = await RequestsAsync.User.GetRecentlyPlayedAsync(UserDetails.UserId.ToString(), "15", offset);
                if (apiStatus == 200)
                {
                    if (respond is GetSoundObject result)
                    {
                        var respondList = result.Data?.SoundList.Count;
                        if (respondList > 0)
                        {
                            result.Data.SoundList = DeepSoundTools.ListFilter(result.Data?.SoundList);

                            foreach (var item in from item in result.Data?.SoundList let check = MAdapter.SoundsList.FirstOrDefault(a => a.Id == item.Id) where check == null select item)
                            {
                                MAdapter.SoundsList.Add(item);

                                if (MAdapter.SoundsList.Count % AppSettings.ShowAdNativeCount == 0)
                                {
                                    MAdapter.SoundsList.Add(new SoundDataObject()
                                    {
                                        TypeView = "Ads"
                                    });
                                }
                            }

                            if (countList > 0)
                            {
                                Activity?.RunOnUiThread(() => { MAdapter.NotifyItemRangeInserted(countList, MAdapter.SoundsList.Count - countList); });
                            }
                            else
                            {
                                Activity?.RunOnUiThread(() => { MAdapter.NotifyDataSetChanged(); });
                            }
                        }
                        else
                        {
                            if (MAdapter.SoundsList.Count > 10 && !MRecycler.CanScrollVertically(1))
                                Toast.MakeText(Context, Context.GetText(Resource.String.Lbl_NoMoreRecentlyPlayed), ToastLength.Short)?.Show();
                        }
                    }
                }
                else
                {
                    MainScrollEvent.IsLoading = false;
                    Methods.DisplayReportResult(Activity, respond);
                }

                Activity?.RunOnUiThread(ShowEmptyPage);
            }
            else
            {
                Inflated = EmptyStateLayout.Inflate();
                EmptyStateInflater x = new EmptyStateInflater();
                x.InflateLayout(Inflated, EmptyStateInflater.Type.NoConnection);
                if (!x.EmptyStateButton.HasOnClickListeners)
                {
                    x.EmptyStateButton.Click += null;
                    x.EmptyStateButton.Click += EmptyStateButtonOnClick;
                }

                Toast.MakeText(Context, GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short)?.Show();
                MainScrollEvent.IsLoading = false;
            }
            MainScrollEvent.IsLoading = false;
        }

        private void ShowEmptyPage()
        {
            try
            {
                ShimmerInflater?.Hide();

                MainScrollEvent.IsLoading = false;
                SwipeRefreshLayout.Refreshing = false;
                SwipeRefreshLayout.Enabled = false;

                if (MAdapter.SoundsList.Count > 0)
                {
                    PopupFilterList.TxtSongName.Text = MAdapter.SoundsList.Count + " " + GetText(Resource.String.Lbl_Songs);

                    PopupFilterList.TopLayout.Visibility = ViewStates.Visible;
                    MRecycler.Visibility = ViewStates.Visible;
                    EmptyStateLayout.Visibility = ViewStates.Gone;
                }
                else
                {
                    PopupFilterList.TopLayout.Visibility = ViewStates.Gone;
                    MRecycler.Visibility = ViewStates.Gone;

                    Inflated ??= EmptyStateLayout.Inflate();

                    EmptyStateInflater x = new EmptyStateInflater();
                    x.InflateLayout(Inflated, EmptyStateInflater.Type.NoSound);
                    if (x.EmptyStateButton.HasOnClickListeners)
                    {
                        x.EmptyStateButton.Click += null;
                    }
                    EmptyStateLayout.Visibility = ViewStates.Visible;
                }
            }
            catch (Exception e)
            {
                ShimmerInflater?.Hide();
                MainScrollEvent.IsLoading = false;

                SwipeRefreshLayout.Enabled = false;
                SwipeRefreshLayout.Refreshing = false;
                Methods.DisplayReportResultTrack(e);
            }
        }

        private void EmptyStateButtonOnClick(object sender, EventArgs e)
        {
            try
            {
                GetSongsByType();
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        #endregion 
    }
}