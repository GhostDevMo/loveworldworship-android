using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidHUD;
using AndroidX.AppCompat.Content.Res;
using AndroidX.AppCompat.Widget;
using DeepSound.Helpers.Ads;
using DeepSound.Helpers.CacheLoaders;
using DeepSound.Helpers.Controller;
using DeepSound.Helpers.Model;
using DeepSound.Helpers.Utils;
using DeepSound.Payment.Utils;
using System;
using System.Linq;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace DeepSound.Activities.SettingsUser.General
{
    [Activity(Icon = "@mipmap/icon", Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.Locale | ConfigChanges.UiMode | ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class WalletActivity : PaymentBaseActivity
    {
        #region Variables Basic

        private ImageView Avatar;
        private TextView TxtProfileName, TxtUsername;

        private TextView TxtMyBalance;
        public EditText TxtAmount;
        private AppCompatButton BtnReplenish;

        private static WalletActivity Instance;

        #endregion

        #region General

        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);
                Methods.App.FullScreenApp(this);

                SetTheme(DeepSoundTools.IsTabDark() ? Resource.Style.MyTheme_Dark : Resource.Style.MyTheme);

                // Create your application here
                SetContentView(Resource.Layout.WalletLayout);

                Instance = this;

                Type = Intent?.GetStringExtra("Type") ?? "";

                //Get Value And Set Toolbar
                InitBuy();
                InitComponent();
                InitToolbar();
                Get_Data_User();

                AdsGoogle.Ad_AdMobNative(this);
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        protected override void OnResume()
        {
            try
            {
                base.OnResume();
                AddOrRemoveEvent(true);
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

        protected override void OnDestroy()
        {
            try
            {
                if (AppSettings.ShowRazorPay) InitRazorPay?.StopRazorPay();
                if (AppSettings.ShowPayStack) PayStackPayment?.StopPayStack();
                if (AppSettings.ShowPaySera) PaySeraPayment?.StopPaySera();
                if (AppSettings.ShowSecurionPay) SecurionPayPayment?.StopSecurionPay();
                if (AppSettings.ShowIyziPay) IyziPayPayment?.StopIyziPay();

                base.OnDestroy();
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }

        #endregion

        #region Menu

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Android.Resource.Id.Home)
            {
                Finish();
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        #endregion

        #region Functions

        private void InitComponent()
        {
            try
            {
                Avatar = FindViewById<ImageView>(Resource.Id.avatar);
                TxtProfileName = FindViewById<TextView>(Resource.Id.name);
                TxtUsername = FindViewById<TextView>(Resource.Id.tv_subname);

                TxtMyBalance = FindViewById<TextView>(Resource.Id.myBalance);

                TxtAmount = FindViewById<EditText>(Resource.Id.AmountEditText);
                BtnReplenish = FindViewById<AppCompatButton>(Resource.Id.ReplenishButton);

                Methods.SetColorEditText(TxtAmount, DeepSoundTools.IsTabDark() ? Color.White : Color.Black);

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
                Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                if (toolbar != null)
                {
                    toolbar.Title = GetText(Resource.String.Lbl_Wallet);
                    toolbar.SetTitleTextColor(DeepSoundTools.IsTabDark() ? Color.White : Color.Black);
                    SetSupportActionBar(toolbar);
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

        private void AddOrRemoveEvent(bool addEvent)
        {
            try
            {
                // true +=  // false -=
                if (addEvent)
                {
                    BtnReplenish.Click += BtnReplenishOnClick;
                }
                else
                {
                    BtnReplenish.Click -= BtnReplenishOnClick;
                }
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

        public static WalletActivity GetInstance()
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

        #endregion

        #region Events

        private void BtnReplenishOnClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtAmount.Text) || string.IsNullOrWhiteSpace(TxtAmount.Text) || Convert.ToInt32(TxtAmount.Text) == 0)
                {
                    Toast.MakeText(this, GetText(Resource.String.Lbl_PleaseEnterAmount), ToastLength.Long)?.Show();
                    return;
                }

                if (!Methods.CheckConnectivity())
                {
                    Toast.MakeText(this, GetText(Resource.String.Lbl_CheckYourInternetConnection), ToastLength.Long)?.Show();
                    return;
                }

                Price = TxtAmount.Text;

                Bundle bundle = new Bundle();
                bundle.PutString("Price", Price);
                bundle.PutString("Type", Type);

                PaymentXBottomSheetDialog bottomSheetDialog = new PaymentXBottomSheetDialog()
                {
                    Arguments = bundle
                };
                bottomSheetDialog.Show(SupportFragmentManager, bottomSheetDialog.Tag);
            }
            catch (Exception exception)
            {
                AndHUD.Shared.Dismiss();
                Methods.DisplayReportResultTrack(exception);
            }
        }

        #endregion

        private async void Get_Data_User()
        {
            try
            {
                if (ListUtils.MyUserInfoList?.Count == 0)
                    await ApiRequest.GetInfoData(this, UserDetails.UserId.ToString());

                var local = ListUtils.MyUserInfoList?.FirstOrDefault();
                if (local != null)
                {
                    GlideImageLoader.LoadImage(this, local.Avatar, Avatar, ImageStyle.CircleCrop, ImagePlaceholders.Drawable);
                    TxtProfileName.Text = DeepSoundTools.GetNameFinal(local);
                    TxtUsername.Text = "@" + local.Username;

                    TxtMyBalance.Text = local.WalletFormat;
                }
            }
            catch (Exception exception)
            {
                Methods.DisplayReportResultTrack(exception);
            }
        }
    }
}