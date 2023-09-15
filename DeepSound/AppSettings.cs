using DeepSound.Helpers.Model;

namespace DeepSound
{
    //For the accuracy of the icon and logo, please use this website " https://appicon.co " and add images according to size in folders " mipmap " 

    internal static class AppSettings
    {
        /// <summary>
        /// Deep Links To App Content
        /// you should add your website without http in the analytic.xml file >> ../values/analytic.xml .. line 5
        /// <string name="ApplicationUrlWeb">loveworldworship.com</string>
        /// </summary>  
        public static readonly string Cert = "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";

        //Main Settings >>>>>
        //*********************************************************
        public static readonly string ApplicationName = "LoveworldWorship";
        public static readonly string DatabaseName = "loveworld_deep";
        public static string Version = "3.2";

        //Main Colors >>
        //*********************************************************
        public static readonly string MainColor = "#FF8216";

        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = false;
        public static string Lang = ""; //Default language ar_AE

        //Error Report Mode
        //*********************************************************
        public static readonly bool SetApisReportMode = false;

        //Notification Settings >>
        //*********************************************************
        public static bool ShowNotification = true;
        public static string OneSignalAppId = "151e6aac-a398-492a-a546-b90e0736e31c";

        //AdMob >> Please add the code ads in the Here and analytic.xml 
        //*********************************************************
        public static readonly ShowAds ShowAds = ShowAds.AllUsers;

        public static readonly bool RewardedAdvertisingSystem = false; //#New

        //Three times after entering the ad is displayed
        public static readonly int ShowAdInterstitialCount = 5;
        public static readonly int ShowAdRewardedVideoCount = 5;
        public static int ShowAdNativeCount = 7;
        public static readonly int ShowAdAppOpenCount = 3;

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

        public static readonly string ClientId = "104516058316-9vjdctmsk63o35nbpp872is04qqa84vc.apps.googleusercontent.com";

        public static string AppNameWoWonder = "WoWonder";
        public static readonly string WoWonderDomainUri = "https://demo.wowonder.com";
        public static readonly string WoWonderAppKey = "131c471c8b4edf662dd0ebf7adf3c3d7365838b9";

        //*********************************************************
        public static readonly bool ShowPrice = false;
        public static readonly bool ShowSkipButton = true;

        //in album
        public static readonly bool ShowCountPurchases = false;

        public static readonly ShareSystem ShareSystem = ShareSystem.ApplicationShortUrl; //#New 

        //Set Theme Full Screen App
        //*********************************************************
        public static readonly bool EnableFullScreenApp = false;

        public static readonly bool EnableOptimizationApp = true;

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
        public static readonly bool ShowTitleAlbumOnly = true;


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
        public static readonly int RefreshAppAPiSeconds = 1000; // 1 Seconds
        public static readonly int MessageRequestSpeed = 1000; // 1 Seconds

        //Set Theme App >> Color - Tab
        //*********************************************************
        public static TabTheme SetTabDarkTheme = TabTheme.Light;

        //Bypass Web Erros 
        //*********************************************************
        public static readonly bool TurnTrustFailureOnWebException = true;
        public static readonly bool TurnSecurityProtocolType3072On = true;

        //Payment System
        //*********************************************************
        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// <uses-permission android:name="com.android.vending.BILLING" />
        /// </summary>
        public static readonly bool ShowInAppBilling = false;

        /// <summary>
        /// Paypal and google pay using Braintree Gateway https://www.braintreepayments.com/
        /// 
        /// Add info keys in Payment Methods : https://prnt.sc/1z5bffc & https://prnt.sc/1z5b0yj
        /// To find your merchant ID :  https://prnt.sc/1z59dy8
        ///
        /// Tokenization Keys : https://prnt.sc/1z59smv
        /// </summary>
        public static readonly bool ShowPaypal = false;
        public static readonly string MerchantAccountId = "test";

        public static readonly string SandboxTokenizationKey = "sandbox_kt2f6mdh_hf4c******";
        public static readonly string ProductionTokenizationKey = "production_t2wns2y2_dfy45******";

        public static readonly bool ShowBankTransfer = false;
        public static readonly bool ShowCreditCard = false;

        public static readonly bool ShowCashFree = false;

        /// <summary>
        /// Currencies : http://prntscr.com/u600ok
        /// </summary>
        public static readonly string CashFreeCurrency = "INR";

        /// <summary>
        /// If you want RazorPay you should change id key in the analytic.xml file
        /// razorpay_api_Key >> .. line 24 
        /// </summary>
        public static readonly bool ShowRazorPay = false;

        /// <summary>
        /// Currencies : https://razorpay.com/accept-international-payments
        /// </summary>
        public static readonly string RazorPayCurrency = "USD";

        public static readonly bool ShowPayStack = false;
        public static readonly bool ShowPaySera = false;

        public static readonly bool ShowPayUmoney = false;
        public static readonly bool ShowAuthorizeNet = false;
        public static readonly bool ShowSecurionPay = false;
        public static readonly bool ShowIyziPay = false;
        public static readonly bool ShowAamarPay = false;

        /// <summary>
        /// FlutterWave get Api Keys From https://app.flutterwave.com/dashboard/settings/apis/live
        /// </summary>
        public static readonly bool ShowFlutterWave = false;//#New 
        public static readonly string FlutterWaveCurrency = "NGN";//#New 
        public static readonly string FlutterWavePublicKey = "FLWPUBK_TEST-9c877b3110438191127e631c8*****";//#New 
        public static readonly string FlutterWaveEncryptionKey = "FLWSECK_TEST298f1****";//#New 

        //********************************************************* 
        public static readonly bool AllowDeletingDownloadedSongs = true;

    }
}