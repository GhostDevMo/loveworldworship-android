﻿using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.View;
using AndroidX.ViewPager2.Widget;
using DeepSound.Activities.MyContacts;
using DeepSound.Activities.MyProfile;
using DeepSound.Activities.SettingsUser;
using DeepSound.Activities.UserProfile.Fragments;
using DeepSound.Adapters;
using DeepSound.Helpers.CacheLoaders;
using DeepSound.Helpers.Controller;
using DeepSound.Helpers.Model;
using DeepSound.Helpers.Utils;
using DeepSound.SQLite;
using DeepSoundClient.Classes.Global;
using DeepSoundClient.Classes.User;
using DeepSoundClient.Requests;
using Google.Android.Material.AppBar;
using Google.Android.Material.Dialog;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Tabs;
using Newtonsoft.Json;
using Refractored.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exception = System.Exception;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace DeepSound.Activities.Tabbes.Fragments
{
    public class ProfileFragment : Fragment, AppBarLayout.IOnOffsetChangedListener, IDialogListCallBack, TabLayoutMediator.ITabConfigurationStrategy
    {
        #region Variables Basic

        private HomeActivity GlobalContext;
        private CollapsingToolbarLayout CollapsingToolbar;
        private AppBarLayout AppBarLayout;
        private ImageView IconPro, IconMore, IconInfo;
        public ImageView ImageCover;
        public CircleImageView ImageAvatar;
        public TextView TxtFullName;
        private TextView TxtCountFollowers, TxtFollowers, TxtCountFollowing, TxtFollowing;
        private AppCompatButton EditButton;
        private ViewPager2 ViewPagerView;
        private TabLayout Tabs;
        private FloatingActionButton BtnEdit;
        private UserActivitiesFragment ActivitiesFragment;
        public UserAlbumsFragment AlbumsFragment;
        public UserLikedFragment LikedFragment;
        public UserPlaylistFragment PlaylistFragment;
        public UserSongsFragment SongsFragment;
        private UserStationsFragment StationsFragment;
        private UserStoreFragment StoreFragment;
        private UserEventsFragment EventFragment;
        public ContactsFragment ContactsFragment;
        private Details DetailsCounter;
        private MainTabAdapter Adapter;

        #endregion

        #region General

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            HasOptionsMenu = true;
            // Create your fragment here
            GlobalContext = (HomeActivity)Activity;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            try
            {
                View view = inflater.Inflate(Resource.Layout.TProfileLayout, container, false);
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

                InitComponent(view);
                SetUpViewPager();

                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                {
                    Activity.Window?.ClearFlags(WindowManagerFlags.TranslucentStatus);
                    Activity.Window?.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                }

                GetMyInfoData();
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

        #endregion

        #region Functions

        private void InitComponent(View view)
        {
            try
            {
                CollapsingToolbar = (CollapsingToolbarLayout)view.FindViewById(Resource.Id.collapsingToolbar);
                CollapsingToolbar.Title = "";

                AppBarLayout = view.FindViewById<AppBarLayout>(Resource.Id.appBarLayout);
                AppBarLayout.SetExpanded(true);
                AppBarLayout.AddOnOffsetChangedListener(this);

                ImageCover = (ImageView)view.FindViewById(Resource.Id.imageCover);

                IconPro = (ImageView)view.FindViewById(Resource.Id.pro);
                IconPro.Visibility = ViewStates.Invisible;

                IconMore = (ImageView)view.FindViewById(Resource.Id.more);
                IconMore.Click += ButtonMoreOnClick;

                IconInfo = (ImageView)view.FindViewById(Resource.Id.info);
                IconInfo.Click += IconInfoOnClick;

                ImageAvatar = (CircleImageView)view.FindViewById(Resource.Id.imageAvatar);
                ImageAvatar.Click += ImageAvatarOnClick;

                TxtFullName = (TextView)view.FindViewById(Resource.Id.fullNameTextView);

                TxtCountFollowers = (TextView)view.FindViewById(Resource.Id.countFollowersTextView);
                TxtFollowers = (TextView)view.FindViewById(Resource.Id.FollowersTextView);
                TxtFollowers.Click += TxtFollowersOnClick;
                TxtCountFollowers.Click += TxtFollowersOnClick;

                TxtCountFollowing = (TextView)view.FindViewById(Resource.Id.countFollowingTextView);
                TxtFollowing = (TextView)view.FindViewById(Resource.Id.FollowingTextView);
                TxtFollowing.Click += TxtFollowingOnClick;
                TxtCountFollowing.Click += TxtFollowingOnClick;

                EditButton = (AppCompatButton)view.FindViewById(Resource.Id.EditButton);
                EditButton.Click += BtnEditOnClick;

                ViewPagerView = (ViewPager2)view.FindViewById(Resource.Id.profileViewPager);
                Tabs = (TabLayout)view.FindViewById(Resource.Id.sectionsTabs);

                BtnEdit = (FloatingActionButton)view.FindViewById(Resource.Id.fab);
                BtnEdit.Click += (s, e) => OpenSettings();

            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

        #region Set Tab

        private void SetUpViewPager()
        {
            try
            {
                ActivitiesFragment = new UserActivitiesFragment();
                AlbumsFragment = new UserAlbumsFragment();
                LikedFragment = new UserLikedFragment();
                PlaylistFragment = new UserPlaylistFragment();
                SongsFragment = new UserSongsFragment();
                StationsFragment = new UserStationsFragment();
                StoreFragment = new UserStoreFragment();
                EventFragment = new UserEventsFragment();

                Bundle bundle = new Bundle();
                bundle.PutString("UserId", UserDetails.UserId.ToString());

                ActivitiesFragment.Arguments = bundle;
                AlbumsFragment.Arguments = bundle;
                LikedFragment.Arguments = bundle;
                PlaylistFragment.Arguments = bundle;
                SongsFragment.Arguments = bundle;
                StationsFragment.Arguments = bundle;
                StoreFragment.Arguments = bundle;
                EventFragment.Arguments = bundle;

                Adapter = new MainTabAdapter(this);
                Adapter.AddFragment(SongsFragment, GetText(Resource.String.Lbl_Songs));
                Adapter.AddFragment(AlbumsFragment, GetText(Resource.String.Lbl_Albums));
                Adapter.AddFragment(PlaylistFragment, GetText(Resource.String.Lbl_Playlist));
                Adapter.AddFragment(LikedFragment, GetText(Resource.String.Lbl_Liked));
                Adapter.AddFragment(ActivitiesFragment, GetText(Resource.String.Lbl_Activities_Title));

                if (AppSettings.ShowStore)
                    Adapter.AddFragment(StoreFragment, GetText(Resource.String.Lbl_Store_Title));

                if (AppSettings.ShowStations)
                    Adapter.AddFragment(StationsFragment, GetText(Resource.String.Lbl_Stations));

                if (AppSettings.ShowEvent)
                    Adapter.AddFragment(EventFragment, GetText(Resource.String.Lbl_Event));

                ViewPagerView.CurrentItem = Adapter.ItemCount;
                ViewPagerView.OffscreenPageLimit = Adapter.ItemCount;

                ViewPagerView.Orientation = ViewPager2.OrientationHorizontal;
                ViewPagerView.RegisterOnPageChangeCallback(new MyOnPageChangeCallback(this));
                ViewPagerView.Adapter = Adapter;
                ViewPagerView.Adapter.NotifyDataSetChanged();

                Tabs.SetTabTextColors(Color.White, Color.ParseColor(AppSettings.MainColor));
                new TabLayoutMediator(Tabs, ViewPagerView, this).Attach();
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        public void OnConfigureTab(TabLayout.Tab tab, int position)
        {
            try
            {
                tab.SetText(Adapter.GetFragment(position));
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        private class MyOnPageChangeCallback : ViewPager2.OnPageChangeCallback
        {
            private readonly ProfileFragment Activity;

            public MyOnPageChangeCallback(ProfileFragment activity)
            {
                try
                {
                    Activity = activity;
                }
                catch (Exception exception)
                {
                    Methods.DisplayReportResultTrack(exception);
                }
            }

            public override void OnPageSelected(int position)
            {
                try
                {
                    base.OnPageSelected(position);
                    var number = Activity.GetSelectedTab(position);

                    switch (number)
                    {
                        //Songs
                        case 1:
                            Activity.SongsFragment?.StartApiServiceWithOffset();
                            break;
                        //Albums
                        case 2:
                            Activity.AlbumsFragment?.StartApiServiceWithOffset();
                            break;
                        //Playlist
                        case 3:
                            Activity.PlaylistFragment?.StartApiServiceWithOffset();
                            break;
                        //Liked
                        case 4:
                            Activity.LikedFragment?.StartApiServiceWithOffset();
                            break;
                        //Activities
                        case 5:
                            Activity.ActivitiesFragment?.StartApiServiceWithOffset();
                            break;
                        //Store
                        case 6:
                            Activity.StoreFragment?.StartApiServiceWithOffset();
                            break;
                        //Stations
                        case 7:
                            Activity.StationsFragment?.StartApiServiceWithOffset();
                            break;
                        //Event
                        case 8:
                            Activity.EventFragment?.StartApiServiceWithOffset();
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Methods.DisplayReportResultTrack(exception);
                }
            }
        }

        private int GetSelectedTab(int number)
        {
            try
            {
                var tabName = Tabs.GetTabAt(number)?.Text;
                if (tabName == Resources.GetText(Resource.String.Lbl_Songs))
                {
                    return 1;
                }
                if (tabName == Resources.GetText(Resource.String.Lbl_Albums))
                {
                    return 2;
                }
                if (tabName == Resources.GetText(Resource.String.Lbl_Playlist))
                {
                    return 3;
                }
                if (tabName == Resources.GetText(Resource.String.Lbl_Liked))
                {
                    return 4;
                }
                if (tabName == Resources.GetText(Resource.String.Lbl_Activities_Title))
                {
                    return 5;
                }
                if (tabName == Resources.GetText(Resource.String.Lbl_Store_Title))
                {
                    return 6;
                }
                if (tabName == Resources.GetText(Resource.String.Lbl_Stations))
                {
                    return 7;
                }
                if (tabName == Resources.GetText(Resource.String.Lbl_Event))
                {
                    return 8;
                }
                return 0;
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
                return 0;
            }
        }

        #endregion

        #region Event

        //Open Edit page profile
        private void BtnEditOnClick(object sender, EventArgs e)
        {
            try
            {
                Intent intent = new Intent(Activity, typeof(EditProfileInfoActivity));
                StartActivityForResult(intent, 200);
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        //More 
        private void ButtonMoreOnClick(object sender, EventArgs e)
        {
            try
            {
                var arrayAdapter = new List<string>();
                var dialogList = new MaterialAlertDialogBuilder(Context);
                arrayAdapter.Add(Context.GetText(Resource.String.Lbl_ChangeCoverImage));
                arrayAdapter.Add(Context.GetText(Resource.String.Lbl_Settings));
                arrayAdapter.Add(Context.GetText(Resource.String.Lbl_CopyLinkToProfile));
                dialogList.SetItems(arrayAdapter.ToArray(), new MaterialDialogUtils(arrayAdapter, this));
                dialogList.SetPositiveButton(Context.GetText(Resource.String.Lbl_Close), new MaterialDialogUtils());

                dialogList.Show();
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        //Show Info User
        private void IconInfoOnClick(object sender, EventArgs e)
        {
            try
            {
                var dataUser = ListUtils.MyUserInfoList?.FirstOrDefault();
                if (dataUser != null)
                {
                    Intent intent = new Intent(Context, typeof(DialogInfoUserActivity));
                    intent.PutExtra("UserId", UserDetails.UserId.ToString());
                    intent.PutExtra("ItemDataDetails", JsonConvert.SerializeObject(DetailsCounter));
                    Context.StartActivity(intent);
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        //Open My Contact >> Following
        private void TxtFollowingOnClick(object sender, EventArgs e)
        {
            try
            {
                Bundle bundle = new Bundle();
                bundle.PutString("UserId", UserDetails.UserId.ToString());
                bundle.PutString("UserType", "Following");

                ContactsFragment = new ContactsFragment
                {
                    Arguments = bundle
                };
                GlobalContext.FragmentBottomNavigator.DisplayFragment(ContactsFragment);
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        //Open My Contact >> Followers
        private void TxtFollowersOnClick(object sender, EventArgs e)
        {
            try
            {
                Bundle bundle = new Bundle();
                bundle.PutString("UserId", UserDetails.UserId.ToString());
                bundle.PutString("UserType", "Followers");

                ContactsFragment = new ContactsFragment
                {
                    Arguments = bundle
                };
                GlobalContext.FragmentBottomNavigator.DisplayFragment(ContactsFragment);
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        //Update Avatar Async
        private void ImageAvatarOnClick(object sender, EventArgs e)
        {
            try
            {
                GlobalContext.OpenDialogGallery("Avatar");
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        #endregion

        #region Load Data User

        private void GetMyInfoData()
        {
            try
            {
                if (ListUtils.MyUserInfoList?.Count == 0)
                {
                    var sqlEntity = new SqLiteDatabase();
                    sqlEntity.GetDataMyInfo();
                }

                var dataUser = ListUtils.MyUserInfoList?.FirstOrDefault();
                LoadDataUser(dataUser);
                StartApiService();
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        private void LoadDataUser(UserDataObject dataUser)
        {
            try
            {
                if (dataUser != null)
                {
                    CollapsingToolbar.Title = DeepSoundTools.GetNameFinal(dataUser);

                    GlideImageLoader.LoadImage(Activity, dataUser.Cover, ImageCover, ImageStyle.CenterCrop, ImagePlaceholders.Drawable);
                    GlideImageLoader.LoadImage(Activity, dataUser.Avatar, ImageAvatar, ImageStyle.CircleCrop, ImagePlaceholders.DrawableUser);

                    TxtFullName.Text = DeepSoundTools.GetNameFinal(dataUser);

                    IconPro.Visibility = dataUser.IsPro == 1 ? ViewStates.Visible : ViewStates.Gone;

                    if (dataUser.Verified == 1)
                        TxtFullName.SetCompoundDrawablesWithIntrinsicBounds(0, 0, Resource.Drawable.icon_checkmark_small_vector, 0);

                    if (SongsFragment?.IsCreated == true)
                        SongsFragment.PopulateData(dataUser.Latestsongs?.FirstOrDefault());

                    if (AlbumsFragment?.IsCreated == true)
                        AlbumsFragment.PopulateData(dataUser.Albums?.FirstOrDefault());

                    if (PlaylistFragment?.IsCreated == true)
                        PlaylistFragment.PopulateData(dataUser.Playlists?.FirstOrDefault());

                    if (LikedFragment?.IsCreated == true)
                        LikedFragment.PopulateData(dataUser.Liked?.FirstOrDefault());

                    if (ActivitiesFragment?.IsCreated == true)
                        ActivitiesFragment.PopulateData(dataUser.Activities?.FirstOrDefault());

                    if (StationsFragment?.IsCreated == true)
                        StationsFragment.PopulateData(dataUser.Stations);

                    if (StoreFragment?.IsCreated == true)
                        StoreFragment.PopulateData(dataUser.Store?.FirstOrDefault());

                    if (EventFragment?.IsCreated == true)
                        EventFragment.PopulateData(dataUser.Events);
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        private void StartApiService()
        {

            if (!Methods.CheckConnectivity())
                Toast.MakeText(Activity, GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short)?.Show();
            else
                PollyController.RunRetryPolicyFunction(new List<Func<Task>> { StartApiFetch });
        }

        private async Task StartApiFetch()
        {
            string fetch = "albums,playlists,liked,activities,latest_songs,top_songs";
            if (AppSettings.ShowStations)
                fetch += ",stations";

            if (AppSettings.ShowStore)
                fetch += ",store";

            if (AppSettings.ShowEvent)
                fetch += ",events";

            var (apiStatus, respond) = await RequestsAsync.User.ProfileAsync(UserDetails.UserId.ToString(), fetch);
            if (apiStatus.Equals(200))
            {
                if (respond is ProfileObject result)
                {
                    if (result.Data != null)
                    {
                        Activity?.RunOnUiThread(() =>
                        {
                            try
                            {
                                UserDetails.Avatar = result.Data.Avatar;
                                UserDetails.Username = result.Data.Username;
                                UserDetails.IsPro = result.Data.IsPro.ToString();
                                UserDetails.Url = result.Data.Url;
                                UserDetails.FullName = result.Data.Name;

                                ListUtils.MyUserInfoList?.Clear();
                                ListUtils.MyUserInfoList?.Add(result.Data);

                                LoadDataUser(result.Data);

                                if (result.Details != null)
                                {
                                    DetailsCounter = result.Details;

                                    TxtCountFollowers.Text = Methods.FunString.FormatPriceValue(result.Details.Followers);
                                    TxtCountFollowing.Text = Methods.FunString.FormatPriceValue(result.Details.Following);
                                    //TxtCountTracks.Text = Methods.FunString.FormatPriceValue(result.Details.LatestSongs);
                                }
                            }
                            catch (Exception e)
                            {
                                Methods.DisplayReportResultTrack(e);
                            }
                        });
                    }
                }
            }
            else
            {
                Methods.DisplayReportResult(Activity, respond);
            }
        }

        #endregion

        #region appBarLayout

        public void OnOffsetChanged(AppBarLayout appBarLayout, int verticalOffset)
        {
            try
            {
                int minHeight = ViewCompat.GetMinimumHeight(CollapsingToolbar) * 2;
                float scale = (float)(minHeight + verticalOffset) / minHeight;

                BtnEdit.ScaleX = scale >= 0 ? scale : 0;
                BtnEdit.ScaleY = scale >= 0 ? scale : 0;
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

        #region MaterialDialog

        public void OnSelection(IDialogInterface dialog, int position, string itemString)
        {
            try
            {
                string text = itemString;
                if (text == Context.GetText(Resource.String.Lbl_ChangeCoverImage))
                {
                    GlobalContext.OpenDialogGallery("Cover");
                }
                else if (text == Context.GetText(Resource.String.Lbl_Settings))
                {
                    OpenSettings();
                }
                else if (text == Context.GetText(Resource.String.Lbl_CopyLinkToProfile))
                {
                    string url = ListUtils.MyUserInfoList?.FirstOrDefault()?.Url;
                    GlobalContext.SoundController.ClickListeners.OnMenuCopyOnClick(url);
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        private void OpenSettings()
        {
            //open settings
            Context.StartActivity(new Intent(Context, typeof(SettingsActivity)));
        }

        #endregion
    }
}