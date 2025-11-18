using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Activity.Result;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Content.Res;
using AndroidX.AppCompat.Widget;
using AndroidX.RecyclerView.Widget;
using AndroidX.SwipeRefreshLayout.Widget;
using AT.Markushi.UI;
using DeepSound.Activities.Chat.Adapters;
using DeepSound.Activities.SettingsUser;
using DeepSound.Activities.Tabbes;
using DeepSound.Helpers.Ads;
using DeepSound.Helpers.Controller;
using DeepSound.Helpers.Model;
using DeepSound.Helpers.Utils;
using DeepSound.SQLite;
using DeepSoundClient.Classes.Chat;
using DeepSoundClient.Classes.Global;
using DeepSoundClient.Requests;
using Developer.SEmojis.Actions;
using Developer.SEmojis.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Console = System.Console;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace DeepSound.Activities.Chat
{
    [Activity(Icon = "@mipmap/icon", Theme = "@style/MyTheme", ResizeableActivity = true, ConfigurationChanges = ConfigChanges.Locale | ConfigChanges.UiMode | ConfigChanges.UiMode | ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MessagesBoxActivity : AppCompatActivity, IActivityResultCallback
    {
        #region Variables Basic

        private AppCompatImageView ChatEmojisImage;
        private RelativeLayout RootView;
        private EmojiconEditText EmojisIconEditTextView;
        private CircleButton ChatSendButton, ImageButton;
        private static Toolbar TopChatToolBar;
        public RecyclerView ChatBoxRecyclerView;
        private LinearLayoutManager MLayoutManager;
        public static UserMessagesAdapter MAdapter;
        private static long Userid;// to_id
        private static Timer Timer;
        private SwipeRefreshLayout SwipeRefreshLayout;
        private UserDataObject UserInfoData;
        private HomeActivity GlobalContext;
        private static MessagesBoxActivity Instance;
        private DialogGalleryController GalleryController;
        private int BeforeMessageId;

        // Add this field to the class
        private int FirstMessageId = 0;

        // Add this field to the class
        private string TaskWork = "Working";

        #endregion

        #region General

        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                Window?.SetSoftInputMode(SoftInput.AdjustResize);
                base.OnCreate(savedInstanceState);

                Window?.SetBackgroundDrawableResource(DeepSoundTools.IsTabDark() ? Resource.Drawable.chatBackground3_Dark : Resource.Drawable.chatBackground);

                Methods.App.FullScreenApp(this);
                SetTheme(DeepSoundTools.IsTabDark() ? Resource.Style.MyTheme_Dark : Resource.Style.MyTheme);

                // Set our view from the "MessagesBox_Layout" layout resource
                SetContentView(Resource.Layout.MessagesBoxLayout);

                Instance = this;

                var data = Intent?.GetStringExtra("UserId") ?? "Data not available";
                if (data != "Data not available" && !string.IsNullOrEmpty(data)) Userid = int.Parse(data); // to_id

                string json = Intent?.GetStringExtra("UserItem");
                var item = JsonConvert.DeserializeObject<UserDataObject>(json);
                if (item != null) UserInfoData = item;

                //Get Value And Set Toolbar
                InitComponent();
                InitToolbar();
                SetRecyclerViewAdapters();
                GalleryController = new DialogGalleryController(this, this);

                //Set Title ToolBar and data chat user After that get messages 
                LoadData_ItemUser();

                AdsGoogle.Ad_RewardedVideo(this);

                GlobalContext = HomeActivity.GetInstance();
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public static MessagesBoxActivity GetInstance()
        {
            try
            {
                return Instance;
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
                return null;
            }
        }

        protected override void OnResume()
        {
            try
            {
                base.OnResume();
                AddOrRemoveEvent(true);

                if (Timer != null)
                {
                    Timer.Enabled = true;
                    Timer.Start();
                }


            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        protected override void OnPause()
        {
            try
            {
                base.OnPause();
                AddOrRemoveEvent(false);

                if (Timer != null)
                {
                    Timer.Enabled = false;
                    Timer.Stop();
                }


            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public override void OnTrimMemory(TrimMemory level)
        {
            try
            {
                GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
                base.OnTrimMemory(level);
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        public override void OnLowMemory()
        {
            try
            {
                GC.Collect(GC.MaxGeneration);
                base.OnLowMemory();
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        protected override void OnDestroy()
        {
            try
            {
                if (Timer != null)
                {
                    Timer.Enabled = false;
                    Timer.Stop();
                    Timer = null;
                }

                MAdapter?.MessageList.Clear();
                MAdapter?.NotifyDataSetChanged();

                base.OnDestroy();
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            try
            {
                base.OnConfigurationChanged(newConfig);

                var currentNightMode = newConfig.UiMode & UiMode.NightMask;
                switch (currentNightMode)
                {
                    case UiMode.NightNo:
                        // Night mode is not active, we're using the light theme
                        SharedPref.ApplyTheme(SharedPref.LightMode);
                        break;
                    case UiMode.NightYes:
                        // Night mode is active, we're using dark theme
                        SharedPref.ApplyTheme(SharedPref.DarkMode);
                        break;
                }

                Delegate.SetLocalNightMode(DeepSoundTools.IsTabDark() ? AppCompatDelegate.ModeNightYes : AppCompatDelegate.ModeNightNo);
                SetTheme(DeepSoundTools.IsTabDark() ? Resource.Style.MyTheme_Dark : Resource.Style.MyTheme);

                Window?.SetBackgroundDrawableResource(DeepSoundTools.IsTabDark() ? Resource.Drawable.chatBackground3_Dark : Resource.Drawable.chatBackground);
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

        #region Functions

        private void InitComponent()
        {
            try
            {
                RootView = FindViewById<RelativeLayout>(Resource.Id.rootChatWindowView);

                ChatEmojisImage = FindViewById<AppCompatImageView>(Resource.Id.emojiicon);
                EmojisIconEditTextView = FindViewById<EmojiconEditText>(Resource.Id.EmojiconEditText5);
                ChatSendButton = FindViewById<CircleButton>(Resource.Id.sendButton);
                ChatBoxRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyler);
                SwipeRefreshLayout = FindViewById<SwipeRefreshLayout>(Resource.Id.swipeRefreshLayout);
                SwipeRefreshLayout.SetColorSchemeResources(Android.Resource.Color.HoloBlueLight, Android.Resource.Color.HoloGreenLight, Android.Resource.Color.HoloOrangeLight, Android.Resource.Color.HoloRedLight);
                SwipeRefreshLayout.SetProgressBackgroundColorSchemeColor(DeepSoundTools.IsTabDark() ? Color.ParseColor("#424242") : Color.ParseColor("#f7f7f7"));
                ImageButton = FindViewById<CircleButton>(Resource.Id.imageButton);

                if (DeepSoundTools.IsTabDark())
                {
                    ImageButton.SetColor(Color.Rgb(40, 40, 40));
                }

                ChatSendButton.Tag = "Text";
                ChatSendButton.SetImageResource(Resource.Drawable.icon_send_vector);

                var emojisIcon = new EmojIconActions(this, RootView, EmojisIconEditTextView, ChatEmojisImage);
                emojisIcon.ShowEmojIcon();

                Methods.SetColorEditText(EmojisIconEditTextView, DeepSoundTools.IsTabDark() ? Color.White : Color.Black);

            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        private void InitToolbar()
        {
            try
            {
                TopChatToolBar = FindViewById<Toolbar>(Resource.Id.toolbar);
                if (TopChatToolBar != null)
                {
                    TopChatToolBar.SetTitleTextColor(DeepSoundTools.IsTabDark() ? Color.White : Color.Black);
                    TopChatToolBar.SetSubtitleTextColor(DeepSoundTools.IsTabDark() ? Color.White : Color.Black);
                    SetSupportActionBar(TopChatToolBar);
                    SupportActionBar.SetDisplayShowCustomEnabled(true);
                    SupportActionBar.SetDisplayHomeAsUpEnabled(true);
                    SupportActionBar.SetHomeButtonEnabled(true);
                    SupportActionBar.SetDisplayShowHomeEnabled(true);

                    var icon = AppCompatResources.GetDrawable(this, AppSettings.FlowDirectionRightToLeft ? Resource.Drawable.icon_back_arrow_right : Resource.Drawable.icon_back_arrow_left);
                    icon?.SetTint(DeepSoundTools.IsTabDark() ? Color.White : Color.Black);
                    SupportActionBar.SetHomeAsUpIndicator(icon);

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

                MAdapter = new UserMessagesAdapter(this);

                ChatBoxRecyclerView.SetItemAnimator(null);

                MLayoutManager = new LinearLayoutManager(this);
                ChatBoxRecyclerView.SetLayoutManager(MLayoutManager);
                ChatBoxRecyclerView.SetAdapter(MAdapter);
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        private void AddOrRemoveEvent(bool addEvent)
        {
            try
            {
                // true +=  // false -=
                if (addEvent)
                {
                    ChatSendButton.Touch += Chat_sendButton_Touch;
                    ImageButton.Click += ImageButtonOnClick;
                }
                else
                {
                    ChatSendButton.Touch -= Chat_sendButton_Touch;
                    ImageButton.Click -= ImageButtonOnClick;
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

        #region Set ToolBar and data chat user

        //Set ToolBar and data chat user
        private void LoadData_ItemUser()
        {
            try
            {
                if (UserInfoData != null)
                {
                    SupportActionBar.Title = DeepSoundTools.GetNameFinal(UserInfoData);

                    //string timeAgo;
                    //if (UserInfoData.Time != null)
                    //    timeAgo = Methods.Time.TimeAgo(UserInfoData.Time.Value, false);
                    //else
                    //    timeAgo = Methods.Time.TimeAgo(Convert.ToInt32(UserInfoData.LastActive), false);

                    //SupportActionBar.Subtitle = GetString(Resource.String.Lbl_Last_seen) + " " + timeAgo;
                    //LastSeenUser = GetString(Resource.String.Lbl_Last_seen) + " " + timeAgo;
                }

                Get_Messages();
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

        #region Get Messages

        //Get Messages Local Or Api
        private void Get_Messages()
        {
            try
            {
                BeforeMessageId = 0;
                MAdapter.MessageList.Clear();
                MAdapter.NotifyDataSetChanged();

                SqLiteDatabase dbDatabase = new SqLiteDatabase();
                var localList = dbDatabase.GetMessagesList(UserDetails.UserId, Userid, BeforeMessageId);
                if (localList == "1") //Database.. Get Messages Local
                {
                    MAdapter.NotifyDataSetChanged();

                    //Scroll Down >> 
                    ChatBoxRecyclerView.ScrollToPosition(MAdapter.MessageList.Count - 1);
                    SwipeRefreshLayout.Refreshing = false;
                    SwipeRefreshLayout.Enabled = false;
                }
                else //Or server.. Get Messages Api
                {
                    SwipeRefreshLayout.Refreshing = true;
                    SwipeRefreshLayout.Enabled = true;
                    GetMessages_API();
                }

                //Set Event Scroll
                RecyclerView.OnScrollListener onScrollListener = new MyScrollListener();
                ChatBoxRecyclerView.AddOnScrollListener(onScrollListener);
                TaskWork = "Working";

                //Run timer
                Timer = new Timer { Interval = AppSettings.MessageRequestSpeed, Enabled = true };
                Timer.Elapsed += TimerOnElapsed_MessageUpdater;
                Timer.Start();
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        //Get Messages From API 
        private async void GetMessages_API()
        {
            try
            {
                if (!Methods.CheckConnectivity())
                {
                    SwipeRefreshLayout.Refreshing = false;
                    SwipeRefreshLayout.Enabled = false;

                    Toast.MakeText(this, GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short);
                }
                else
                {
                    BeforeMessageId = 0;

                    var (apiStatus, respond) = await RequestsAsync.Chat.GetChatConversationsAsync(Userid.ToString());
                    if (apiStatus == 200)
                    {
                        if (respond is GetChatConversationsObject result)
                        {
                            if (result.Data.Count > 0)
                            {
                                MAdapter.MessageList = new ObservableCollection<ChatMessagesDataObject>(result.Data);
                                MAdapter.NotifyDataSetChanged();

                                //Insert to DataBase
                                SqLiteDatabase dbDatabase = new SqLiteDatabase();
                                dbDatabase.InsertOrReplaceMessages(MAdapter.MessageList);

                                //Scroll Down >> 
                                ChatBoxRecyclerView.ScrollToPosition(MAdapter.MessageList.Count - 1);

                                SwipeRefreshLayout.Refreshing = false;
                                SwipeRefreshLayout.Enabled = false;
                            }
                        }
                    }
                    else Methods.DisplayReportResult(this, respond);

                    SwipeRefreshLayout.Refreshing = false;
                    SwipeRefreshLayout.Enabled = false;
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
                SwipeRefreshLayout.Refreshing = false;
                SwipeRefreshLayout.Enabled = false;
            }
        }

        #endregion

        //Timer Message Updater >> Get New Message
        private void TimerOnElapsed_MessageUpdater(object sender, ElapsedEventArgs e)
        {
            try
            {
                //Code get last Message id where Updater > >
                MessageUpdater();
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        #region Updater

        private async void MessageUpdater()
        {
            try
            {
                if (TaskWork == "Working")
                {
                    TaskWork = "Stop";

                    if (!Methods.CheckConnectivity())
                    {
                        SwipeRefreshLayout.Refreshing = false;
                        Toast.MakeText(this, GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short);
                    }
                    else
                    {
                        int countList = MAdapter.MessageList.Count;
                        string afterId = MAdapter.MessageList.LastOrDefault()?.Id.ToString() ?? "";
                        var (apiStatus, respond) = await RequestsAsync.Chat.GetChatConversationsAsync(Userid.ToString(), "30", afterId);
                        if (apiStatus == 200)
                        {
                            if (respond is GetChatConversationsObject result)
                            {
                                int responseList = result.Data.Count;
                                if (responseList > 0)
                                {
                                    if (countList > 0)
                                    {
                                        foreach (var item in from item in result.Data let check = MAdapter.MessageList.FirstOrDefault(a => a.Id == item.Id) where check == null select item)
                                        {
                                            MAdapter.MessageList.Add(item);

                                            int index = MAdapter.MessageList.IndexOf(item);
                                            if (index > -1)
                                            {
                                                RunOnUiThread(() =>
                                                {
                                                    try
                                                    {
                                                        MAdapter.NotifyItemInserted(index);

                                                        //Scroll Down >> 
                                                        ChatBoxRecyclerView.ScrollToPosition(MAdapter.MessageList.Count - 1);
                                                    }
                                                    catch (Exception ee)
                                                    {
                                                        Console.WriteLine(ee);
                                                    }
                                                });
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MAdapter.MessageList = new ObservableCollection<ChatMessagesDataObject>(result.Data);
                                    }

                                    RunOnUiThread(() =>
                                    {
                                        try
                                        {
                                            var lastCountItem = MAdapter.ItemCount;
                                            if (countList > 0)
                                                MAdapter.NotifyItemRangeInserted(lastCountItem, MAdapter.MessageList.Count - 1);
                                            else
                                                MAdapter.NotifyDataSetChanged();

                                            //Insert to DataBase
                                            SqLiteDatabase dbDatabase = new SqLiteDatabase();
                                            dbDatabase.InsertOrReplaceMessages(MAdapter.MessageList);

                                            //Scroll Down >> 
                                            ChatBoxRecyclerView.ScrollToPosition(MAdapter.MessageList.Count - 1);

                                            var lastMessage = MAdapter.MessageList.LastOrDefault();
                                            if (lastMessage != null)
                                            {
                                                var dataUser = LastChatActivity.MAdapter.UserList?.FirstOrDefault(a => a.User.Id == Userid);
                                                if (dataUser?.GetLastMessage != null)
                                                {
                                                    dataUser.GetLastMessage.Value.GetLastMessageClass.Text = lastMessage.Text;
                                                    int index = LastChatActivity.MAdapter.UserList.IndexOf(dataUser);

                                                    LastChatActivity.MAdapter.UserList.Move(index, 0);
                                                    LastChatActivity.MAdapter.NotifyItemMoved(index, 0);

                                                    var data = LastChatActivity.MAdapter.UserList.FirstOrDefault(a => a.User.Id == dataUser.User.Id);
                                                    if (data != null)
                                                    {
                                                        data.User = dataUser.User;
                                                        data.GetCountSeen = dataUser.GetCountSeen;
                                                        data.GetLastMessage = dataUser.GetLastMessage;
                                                        data.ChatTime = dataUser.ChatTime;

                                                        LastChatActivity.MAdapter.NotifyItemChanged(LastChatActivity.MAdapter.UserList.IndexOf(data));
                                                    }
                                                }
                                            }

                                            if (AppSettings.RunSoundControl)
                                                Methods.AudioRecorderAndPlayer.PlayAudioFromAsset("Popup_GetMesseges.mp3");

                                        }
                                        catch (Exception e)
                                        {
                                            Methods.DisplayReportResultTrack(e);
                                        }
                                    });
                                }
                            }
                        }
                        else Methods.DisplayReportResult(this, respond);
                    }
                    TaskWork = "Working";
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
                TaskWork = "Working";
            }
        }

        public static void UpdateOneMessage(ChatMessagesDataObject messages)
        {
            try
            {
                var checker = MAdapter.MessageList.FirstOrDefault(a => a.Id == messages.Id);
                if (checker != null)
                {
                    checker.Id = messages.Id;
                    checker.FromId = messages.FromId;
                    checker.ToId = messages.ToId;
                    checker.Text = messages.Text;
                    checker.Seen = messages.Seen;
                    checker.Time = messages.Time;
                    checker.FromDeleted = messages.FromDeleted;
                    checker.ToDeleted = messages.ToDeleted;
                    checker.SentPush = messages.SentPush;
                    checker.NotificationId = messages.NotificationId;
                    checker.TypeTwo = messages.TypeTwo;
                    checker.Image = messages.Image;
                    checker.FullImage = messages.FullImage;
                    checker.ApiPosition = messages.ApiPosition;
                    checker.ApiType = messages.ApiType;

                    MAdapter.NotifyItemChanged(MAdapter.MessageList.IndexOf(checker));
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        #endregion

        #region Load More

        private async void LoadMoreMessages()
        {
            try
            {
                //Run Load More Api 
                var local = LoadMoreMessagesDatabase();
                if (local == "1")
                {

                }
                else
                {
                    var api = await LoadMoreMessagesApi();
                    if (api == "1")
                    {

                    }
                    else
                    {
                        SwipeRefreshLayout.Refreshing = false;
                        SwipeRefreshLayout.Enabled = false;
                    }
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        private string LoadMoreMessagesDatabase()
        {
            try
            {
                SqLiteDatabase dbDatabase = new SqLiteDatabase();
                var localList = dbDatabase.GetMessageList(Convert.ToInt32(UserDetails.UserId), Userid, FirstMessageId);
                if (localList?.Count > 0) //Database.. Get Messages Local
                {
                    localList = new List<DataTables.MessageTb>(localList.OrderByDescending(a => a.Id));

                    foreach (var message in localList.Select(messages => new ChatMessagesDataObject
                    {
                        Id = messages.Id,
                        FromId = messages.FromId,
                        ToId = messages.ToId,
                        Text = messages.Text,
                        Seen = messages.Seen,
                        Time = messages.Time,
                        FromDeleted = messages.FromDeleted,
                        ToDeleted = messages.ToDeleted,
                        SentPush = messages.SentPush,
                        NotificationId = messages.NotificationId,
                        TypeTwo = messages.TypeTwo,
                        Image = messages.Image,
                        FullImage = messages.FullImage,
                        ApiPosition = JsonConvert.DeserializeObject<ApiPosition>(messages.ApiPosition),
                        ApiType = JsonConvert.DeserializeObject<ApiType>(messages.ApiType),
                    }))
                    {
                        MAdapter.MessageList.Insert(0, message);
                        MAdapter.NotifyItemInserted(MAdapter.MessageList.IndexOf(MAdapter.MessageList.FirstOrDefault()));

                        var index = MAdapter.MessageList.FirstOrDefault(a => a.Id == FirstMessageId);
                        if (index == null) continue;
                        MAdapter.NotifyItemChanged(MAdapter.MessageList.IndexOf(index));
                        //Scroll Down >> 
                        ChatBoxRecyclerView.ScrollToPosition(MAdapter.MessageList.IndexOf(index));
                    }
                    return "1";
                }
                return "0";
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
                return "0";
            }
        }

        private async Task<string> LoadMoreMessagesApi()
        {
            try
            {
                if (!Methods.CheckConnectivity())
                {
                    Toast.MakeText(this, GetString(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Short);
                    return "0";
                }

                var (apiStatus, respond) = await RequestsAsync.Chat.GetChatConversationsAsync(Userid.ToString(), "30", FirstMessageId.ToString());
                if (apiStatus == 200)
                {
                    if (respond is GetChatConversationsObject result)
                    {
                        int responseList = result.Data.Count;
                        if (responseList > 0)
                        {
                            foreach (var item in from item in result.Data let check = MAdapter.MessageList.FirstOrDefault(a => a.Id == item.Id) where check == null select item)
                            {
                                MAdapter.MessageList.Insert(0, item);

                                int index = MAdapter.MessageList.IndexOf(item);
                                if (index > -1)
                                {
                                    RunOnUiThread(() =>
                                    {
                                        try
                                        {
                                            MAdapter.NotifyItemInserted(index);

                                            //Scroll Down >> 
                                            ChatBoxRecyclerView.ScrollToPosition(MAdapter.MessageList.IndexOf(MAdapter.MessageList.FirstOrDefault(a => a.Id == FirstMessageId)));
                                        }
                                        catch (Exception ee)
                                        {
                                            Console.WriteLine(ee);
                                        }
                                    });
                                }
                            }

                            RunOnUiThread(() =>
                            {
                                try
                                {

                                    MAdapter.NotifyItemRangeInserted(0, responseList);

                                    //Insert to DataBase
                                    SqLiteDatabase dbDatabase = new SqLiteDatabase();
                                    dbDatabase.InsertOrReplaceMessages(MAdapter.MessageList);

                                    var firstItem = MAdapter.MessageList.FirstOrDefault();
                                    if (firstItem != null)
                                    {
                                        FirstMessageId = (int)firstItem.Id;

                                        var dataUser = LastChatActivity.MAdapter.UserList?.FirstOrDefault(a => a.User.Id == Userid);
                                        if (dataUser?.GetLastMessage != null)
                                        {
                                            dataUser.GetLastMessage.Value.GetLastMessageClass.Text = firstItem.Text;
                                            int index = LastChatActivity.MAdapter.UserList.IndexOf(dataUser);

                                            LastChatActivity.MAdapter.UserList.Move(index, 0);
                                            LastChatActivity.MAdapter.NotifyItemMoved(index, 0);

                                            var data = LastChatActivity.MAdapter.UserList.FirstOrDefault(a => a.User.Id == dataUser.User.Id);
                                            if (data != null)
                                            {
                                                data.User = dataUser.User;
                                                data.GetCountSeen = dataUser.GetCountSeen;
                                                data.GetLastMessage = dataUser.GetLastMessage;
                                                data.ChatTime = dataUser.ChatTime;

                                                LastChatActivity.MAdapter.NotifyItemChanged(LastChatActivity.MAdapter.UserList.IndexOf(data));
                                            }
                                        }
                                    }

                                    SwipeRefreshLayout.Refreshing = false;
                                    SwipeRefreshLayout.Enabled = false;
                                }
                                catch (Exception e)
                                {
                                    Methods.DisplayReportResultTrack(e);
                                }
                            });
                        }
                    }
                }
                else Methods.DisplayReportResult(this, respond);

                return "1";
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
                return "0";
            }
        }

        #endregion

        private void ImageButtonOnClick(object sender, EventArgs e)
        {
            try
            {
                //GalleryController.ShowDialog(GalleryController.OpenMedia.Gallery);
                Toast.MakeText(this, "Media", ToastLength.Short).Show();
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        private void Chat_sendButton_Touch(object sender, View.TouchEventArgs e)
        {
            try
            {
                if (e.Event.Action == MotionEventActions.Down)
                {
                    ChatSendButton.SetImageResource(Resource.Drawable.icon_send_vector);
                }
                else if (e.Event.Action == MotionEventActions.Up)
                {
                    ChatSendButton.SetImageResource(Resource.Drawable.icon_send_vector);
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        public void OnActivityResult(Java.Lang.Object p0)
        {
            // TODO: Handle the activity result here as needed for your app.
            // For now, this is a stub implementation.
        }

        private class MyScrollListener : RecyclerView.OnScrollListener
        {
            public override void OnScrolled(RecyclerView recyclerView, int dx, int dy)
            {
                base.OnScrolled(recyclerView, dx, dy);
                // Add your scroll logic here if needed
            }
        }
    }
}