using DeepSound.Helpers.Model;

namespace DeepSound
{
    //For the accuracy of the icon and logo, please use this website " https://appicon.co " and add images according to size in folders " mipmap " 

    internal static class AppSettings
    {
        /// <summary>
        /// you should add your website without http in the analytic.xml file >> ../values/analytic.xml .. line 5
        /// <string name="ApplicationUrlWeb">deepsoundscript.com</string>
        /// </summary>  
        public static readonly string Cert = "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";

        //Main Settings >>>>>
        //*********************************************************
        public static readonly string ApplicationName = "LoveworldWorship";
        public static readonly string DatabaseName = "loveworld_deep";
        public static string Version = "2.7";

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

        //Three times after entering the ad is displayed
        public static readonly int ShowAdInterstitialCount = 3;
        public static readonly int ShowAdRewardedVideoCount = 3;
        public static int ShowAdNativeCount = 5;
        public static readonly int ShowAdAppOpenCount = 2;

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

        //Colony Ads >> Please add the code ad in the Here 
        //*********************************************************  
        public static readonly bool ShowColonyBannerAds = false;
        public static readonly bool ShowColonyInterstitialAds = false;
        public static readonly bool ShowColonyRewardAds = false;

        public static readonly string AdsColonyAppId = "appc1a3a39f4257436fb0";
        public static readonly string AdsColonyBannerId = "vzf3427a794942477a91";
        public static readonly string AdsColonyInterstitialId = "vz0df8be89b80d41a9ba";
        public static readonly string AdsColonyRewardedId = "vzd163d9467cbc4ab681";
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


        //Set Theme Full Screen App
        //*********************************************************
        public static readonly bool EnableFullScreenApp = false;

        public static readonly bool EnableOptimizationApp = true;

        public static readonly bool ShowSettingsRateApp = true;
        public static readonly int ShowRateAppCount = 5;

        public static readonly bool ShowSettingsHelp = true;
        public static readonly bool ShowSettingsTermsOfUse = true;
        public static bool ShowSettingsAbout = true;
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
        public static readonly PlayerTheme PlayerTheme = PlayerTheme.Theme2;//#New

        public static readonly bool ShowForwardTrack = true;
        public static readonly bool ShowBackwardTrack = true;

        //Show Title Album Only on song
        public static readonly bool ShowTitleAlbumOnly = true;


        //Settings Page >>  
        //*********************************************************
        public static readonly bool ShowEditPassword = true;
        public static readonly bool ShowWithdrawals = false;
        public static readonly bool ShowGoPro = false;
        public static readonly bool ShowBlockedUsers = true;
        public static readonly bool ShowBlog = false;
        public static readonly bool ShowSettingsTwoFactor = false;
        public static readonly bool ShowSettingsManageSessions = false;
        public static readonly bool ShowSettingsMyAffiliates = false;

        //Last_Messages Page >>
        //********************************************************* 
        public static readonly bool RunSoundControl = true;
        public static readonly int RefreshAppAPiSeconds = 6000; // 6 Seconds
        public static readonly int MessageRequestSpeed = 3000; // 3 Seconds

        //Set Theme App >> Color - Tab
        //*********************************************************
        public static TabTheme SetTabDarkTheme = TabTheme.Light;

        //Bypass Web Erros 
        //*********************************************************
        public static readonly bool TurnTrustFailureOnWebException = true;
        public static readonly bool TurnSecurityProtocolType3072On = true;

        //*********************************************************
        public static readonly bool RenderPriorityFastPostLoad = true;

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

        //********************************************************* 
        public static readonly bool AllowDeletingDownloadedSongs = true;


    }
}