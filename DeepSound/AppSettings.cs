using DeepSound.Helpers.Model;
using System.Collections.Generic;

namespace DeepSound
{
    //For the accuracy of the icon and logo, please use this website " https://appicon.co " and add images according to size in folders " mipmap " 
    internal static class AppSettings
    {
        /// <summary>
        /// Deep Links To App Content
        /// you should add your website without http in the analytic.xml file >> ../values/analytic.xml .. line 5
        /// <string name="ApplicationUrlWeb">loveworldworship.com/worship</string>
        /// </summary>  
        public static readonly string Cert = "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";

        //Main Settings >>>>>
        //*********************************************************
        public static readonly string ApplicationName = "Loveworld Music";
        public static readonly string DatabaseName = "admin_lovewor";
        public static string Version = "5.0";

        //Main Colors >>
        //*********************************************************
        public static readonly string MainColor = "#ff5757";

        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = false;
        public static string Lang = ""; //Default language ar

        public static readonly Dictionary<string, string> LanguageList = new Dictionary<string, string>()
        {
            {"en", "English"},
            {"ar", "Arabic"},
        };

        //Error Report Mode
        //*********************************************************
        public static readonly bool SetApisReportMode = false;

        //Notification Settings >>
        //*********************************************************
        public static readonly bool ShowNotification = true;
        public static string OneSignalAppId = "bfc2e195-6c3c-4123-97ce-1e122f5809a9";

        //AdMob >> Please add the code ads in the Here and analytic.xml 
        //*********************************************************
        public static readonly ShowAds ShowAds = ShowAds.AllUsers;

        public static readonly bool RewardedAdvertisingSystem = false;

        //Three times after entering the ad is displayed
        public static readonly int ShowAdInterstitialCount = 8;
        public static readonly int ShowAdRewardedVideoCount = 10;
        public static readonly int ShowAdNativeCount = 8;
        public static readonly int ShowAdAppOpenCount = 6;

        public static readonly bool ShowAdMobBanner = false;
        public static readonly bool ShowAdMobInterstitial = false;
        public static readonly bool ShowAdMobRewardVideo = false;
        public static readonly bool ShowAdMobNative = false;
        public static readonly bool ShowAdMobAppOpen = false;
        public static readonly bool ShowAdMobRewardedInterstitial = false;

        public static readonly string AdInterstitialKey = "ca-app-pub-5135691635931982/6646750931";
        public static readonly string AdRewardVideoKey = "ca-app-pub-5135691635931982/6981792857";
        public static readonly string AdAdMobNativeKey = "ca-app-pub-5135691635931982/1394424252";
        public static readonly string AdAdMobAppOpenKey = "ca-app-pub-5135691635931982/1906896275";
        public static readonly string AdRewardedInterstitialKey = "ca-app-pub-5135691635931982/4054725070";

        //FaceBook Ads >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static readonly bool ShowFbBannerAds = false;
        public static readonly bool ShowFbInterstitialAds = false;
        public static readonly bool ShowFbRewardVideoAds = false;
        public static readonly bool ShowFbNativeAds = false;

        //YOUR_PLACEMENT_ID
        public static readonly string AdsFbBannerKey = "250485588986218_554026418632132";
        public static readonly string AdsFbInterstitialKey = "250485588986218_554026125298828";
        public static readonly string AdsFbRewardVideoKey = "250485588986218_554072818627492";
        public static readonly string AdsFbNativeKey = "250485588986218_554706301897477";

        //Ads AppLovin >> Please add the code ad in the Here 
        //*********************************************************  
        public static readonly bool ShowAppLovinBannerAds = false;
        public static readonly bool ShowAppLovinInterstitialAds = false;
        public static readonly bool ShowAppLovinRewardAds = false;

        public static readonly string AdsAppLovinBannerId = "93a37dd25bd3f699";
        public static readonly string AdsAppLovinInterstitialId = "5fec6909ce79fb49";
        public static readonly string AdsAppLovinRewardedId = "3fdddf11aca6ce57";
        //********************************************************* 

        //Social Logins >>
        //If you want login with facebook or google you should change id key in the analytic.xml file  
        //Facebook >> ../values/analytic.xml .. line 10 - 11
        //Google >> ../values/analytic.xml .. line 15
        //*********************************************************
        public static readonly bool EnableSmartLockForPasswords = false;

        public static readonly bool ShowFacebookLogin = false;
        public static readonly bool ShowGoogleLogin = false;
        public static readonly bool ShowWoWonderLogin = false;

        public static readonly string ClientId = "730099487924-k5lna1uju8fbju7g31uhe7atffh2jnv1.apps.googleusercontent.com";

        public static string AppNameWoWonder = "WoWonder";
        public static readonly string WoWonderDomainUri = "https://demo.wowonder.com";
        public static readonly string WoWonderAppKey = "131c471c8b4edf662dd0ebf7adf3c3d7365838b9";

        //*********************************************************
        public static readonly bool ShowPrice = true;
        public static readonly bool ShowSkipButton = true;

        //in album
        public static readonly bool ShowCountPurchases = true;

        public static readonly ShareSystem ShareSystem = ShareSystem.ApplicationShortUrl;

        //Set Theme Full Screen App
        //*********************************************************
        public static readonly bool EnableFullScreenApp = false;

        public static readonly bool EnableOptimizationApp = false;

        public static readonly bool ShowSettingsRateApp = false;
        public static readonly int ShowRateAppCount = 5;

        public static readonly bool ShowSettingsHelp = true;
        public static readonly bool ShowSettingsTermsOfUse = true;
        public static bool ShowSettingsAbout = false;
        public static readonly bool ShowSettingsDeleteAccount = true;

        public static readonly bool ShowSettingsUpdateManagerApp = false;

        public static readonly bool ShowTextWithSpace = false;

        //Set Blur Screen Comment
        //*********************************************************
        public static readonly bool EnableBlurBackgroundComment = true;

        //Set the radius of the Blur. Supported range 0 < radius <= 25
        public static readonly float BlurRadiusComment = 25f;

        //Import && Upload Videos >>  
        //*********************************************************
        public static bool ShowButtonUploadSingleSong { get; set; } = false;
        public static bool ShowButtonUploadAlbum { get; set; } = false;
        public static bool ShowButtonImportSong { get; set; } = false;

        //Story
        //*********************************************************
        public static readonly bool ShowStory = false;
        public static readonly bool EnableStorySeenList = false;

        //Tap profile
        //*********************************************************
        public static readonly bool ShowStore = false;
        public static readonly bool ShowStations = false;
        public static readonly bool ShowPlaylist = true;
        public static readonly bool ShowEvent = false;
        public static readonly bool ShowProduct = false;
        public static readonly bool ShowAdvertise = false;

        //Offline Sound >>  
        //*********************************************************
        public static readonly bool AllowOfflineDownload = false;

        //Profile >>  
        //*********************************************************
        public static readonly bool ShowEmail = true;

        //Player >>  
        //*********************************************************
        public static readonly PlayerTheme PlayerTheme = PlayerTheme.Theme2;

        public static readonly bool ShowForwardTrack = true;
        public static readonly bool ShowBackwardTrack = true;

        //Show Title Album Only on song
        public static readonly bool ShowTitleAlbumOnly = false;


        //Settings Page >>  
        //*********************************************************
        public static readonly bool ShowEditPassword = true;
        public static readonly bool ShowWithdrawals = false;
        public static readonly bool ShowGoPro = false;
        public static readonly bool ShowBlockedUsers = false;
        public static readonly bool ShowBlog = false;
        public static readonly bool ShowSettingsTwoFactor = false;
        public static readonly bool ShowSettingsManageSessions = false;
        public static readonly bool ShowSettingsMyAffiliates = false;
        public static readonly bool ShowBecomeAnArtist = false;

        //Last_Messages Page >>
        //********************************************************* 
        public static readonly bool RunSoundControl = true;
        public static readonly int RefreshAppAPiSeconds = 6000; // 6 Seconds
        public static readonly int MessageRequestSpeed = 3000; // 3 Seconds

        //Set Theme App >> Color - Tab
        //*********************************************************
        public static TabTheme SetTabDarkTheme = TabTheme.Dark;

        //Bypass Web Erros 
        //*********************************************************
        public static readonly bool TurnTrustFailureOnWebException = true;
        public static readonly bool TurnSecurityProtocolType3072On = true;

        //Payment System
        //*********************************************************
        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// &lt;uses-permission android:name="com.android.vending.BILLING" /&gt;
        /// </summary>
        public static readonly bool ShowInAppBilling = false;

        /// <summary>
        /// Paypal and google pay using Braintree Gateway https://www.braintreepayments.com/
        /// Add info keys in Payment Methods:
        /// https://prnt.sc/1z5bffc and https://prnt.sc/1z5b0yj
        /// To find your merchant ID :  https://prnt.sc/1z59dy8
        /// Tokenization Keys : https://prnt.sc/1z59smv
        /// </summary>
        public static readonly bool ShowPaypal = true;
        public static readonly string MerchantAccountId = "test";

        public static readonly string SandboxTokenizationKey = "sandbox_kt2f6mdh_hf4c******";
        public static readonly string ProductionTokenizationKey = "production_t2wns2y2_dfy45******";

        public static readonly bool ShowBankTransfer = false;// not working now to next update 
        public static readonly bool ShowCreditCard = true;

        public static readonly bool ShowCashFree = true;

        /// <summary>
        /// Currencies : http://prntscr.com/u600ok
        /// </summary>
        public static readonly string CashFreeCurrency = "INR";

        /// <summary>
        /// If you want RazorPay you should change id key in the analytic.xml file
        /// razorpay_api_Key >> .. line 24 
        /// </summary>
        public static readonly bool ShowRazorPay = true;

        /// <summary>
        /// Currencies : https://razorpay.com/accept-international-payments
        /// </summary>
        public static readonly string RazorPayCurrency = "USD";

        public static readonly bool ShowPayStack = true;
        public static readonly bool ShowPaySera = false;

        public static readonly bool ShowPayUmoney = true;
        public static readonly bool ShowAuthorizeNet = true;
        public static readonly bool ShowSecurionPay = true;
        public static readonly bool ShowIyziPay = true;
        public static readonly bool ShowAamarPay = true;

        /// <summary>
        /// FlutterWave get Api Keys From https://app.flutterwave.com/dashboard/settings/apis/live
        /// </summary>
        public static readonly bool ShowFlutterWave = true;
        public static readonly string FlutterWaveCurrency = "NGN";
        public static readonly string FlutterWavePublicKey = "FLWPUBK_TEST-9c877b3110438191127e631c8*****";
        public static readonly string FlutterWaveEncryptionKey = "FLWSECK_TEST298f1****";

        //********************************************************* 
        public static readonly bool AllowDeletingDownloadedSongs = true;

    }
}