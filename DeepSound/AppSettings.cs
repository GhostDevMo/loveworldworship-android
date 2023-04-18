using DeepSound.Helpers.Model;

namespace DeepSound
{
    //For the accuracy of the icon and logo, please use this website " https://appicon.co " and add images according to size in folders " mipmap " 

    internal static class AppSettings
    {
        /// <summary>
        /// you should add your website without http in the analytic.xml file >> ../values/analytic.xml .. line 5
        /// <string name="ApplicationUrlWeb">loveworldworship.com/worship</string>
        /// </summary>  
        public static string Cert = "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";
        
        //Main Settings >>>>>
        //*********************************************************
        public static string ApplicationName = "LoveworldWorship";
        public static string DatabaseName = "lovewurld_deep"; 
        public static string Version = "2.5";

        //Main Colors >>
        //*********************************************************
        public static string MainColor = "#FF8216";

        public static string BackgroundGradationColor1 = "#3033c6";  
        public static string BackgroundGradationColor2 = "#fb0049";  

        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = false;
        public static string Lang = ""; //Default language ar_AE

        //Error Report Mode
        //*********************************************************
        public static bool SetApisReportMode = false;

        //Notification Settings >>
        //*********************************************************
        public static bool ShowNotification = true;
        public static string OneSignalAppId = "151e6aac-a398-492a-a546-b90e0736e31c";
         
        //AdMob >> Please add the code ads in the Here and analytic.xml 
        //*********************************************************
        public static ShowAds ShowAds = ShowAds.AllUsers;

        //Three times after entering the ad is displayed
        public static int ShowAdInterstitialCount = 3;
        public static int ShowAdRewardedVideoCount = 3;
        public static int ShowAdNativeCount = 5;
        public static int ShowAdAppOpenCount = 2;
          
        public static bool ShowAdMobBanner = false;
        public static bool ShowAdMobInterstitial = false;
        public static bool ShowAdMobRewardVideo = false;
        public static bool ShowAdMobNative = false;
        public static bool ShowAdMobAppOpen = false;  
        public static bool ShowAdMobRewardedInterstitial = false;  

        public static string AdInterstitialKey = "ca-app-pub-5135691635931982/6646750931";
        public static string AdRewardVideoKey = "ca-app-pub-5135691635931982/6981792857";
        public static string AdAdMobNativeKey = "ca-app-pub-5135691635931982/1394424252";
        public static string AdAdMobAppOpenKey = "ca-app-pub-5135691635931982/1906896275";  
        public static string AdRewardedInterstitialKey = "ca-app-pub-5135691635931982/4054725070";
         
        //FaceBook Ads >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static bool ShowFbBannerAds = false; 
        public static bool ShowFbInterstitialAds = false;  
        public static bool ShowFbRewardVideoAds = false;  
        public static bool ShowFbNativeAds = false; 

        //YOUR_PLACEMENT_ID
        public static string AdsFbBannerKey = "250485588986218_554026418632132"; 
        public static string AdsFbInterstitialKey = "250485588986218_554026125298828";  
        public static string AdsFbRewardVideoKey = "250485588986218_554072818627492"; 
        public static string AdsFbNativeKey = "250485588986218_554706301897477";

        //Colony Ads >> Please add the code ad in the Here 
        //*********************************************************  
        public static bool ShowColonyBannerAds = false; 
        public static bool ShowColonyInterstitialAds = false; 
        public static bool ShowColonyRewardAds = false; 

        public static string AdsColonyAppId = "appc1a3a39f4257436fb0";
        public static string AdsColonyBannerId = "vzf3427a794942477a91";
        public static string AdsColonyInterstitialId = "vz0df8be89b80d41a9ba";
        public static string AdsColonyRewardedId = "vzd163d9467cbc4ab681";
        //*********************************************************   

        //Social Logins >>
        //If you want login with facebook or google you should change id key in the analytic.xml file  
        //Facebook >> ../values/analytic.xml .. line 10 - 11
        //Google >> ../values/analytic.xml .. line 15
        //*********************************************************
        public static bool EnableSmartLockForPasswords = false;
        
        public static bool ShowFacebookLogin = false;
        public static bool ShowGoogleLogin = false; 
        public static bool ShowWoWonderLogin = false;  

        public static string ClientId = "104516058316-9vjdctmsk63o35nbpp872is04qqa84vc.apps.googleusercontent.com";

        public static string AppNameWoWonder = "WoWonder";
        public static readonly string WoWonderDomainUri = "https://demo.wowonder.com";
        public static readonly string WoWonderAppKey = "131c471c8b4edf662dd0ebf7adf3c3d7365838b9";

        //*********************************************************
        public static bool ShowPrice = false;
        public static bool ShowSkipButton = true;

        //in album
        public static bool ShowCountPurchases = false; 

        //Show Title Album Only on song
        public static bool ShowTitleAlbumOnly = false;  

        //Set Theme Full Screen App
        //*********************************************************
        public static bool EnableFullScreenApp = true;

        public static bool EnableOptimizationApp = true;  

        public static bool ShowSettingsRateApp = false;  
        public static int ShowRateAppCount = 5;

        public static bool ShowSettingsHelp = false; 
        public static bool ShowSettingsTermsOfUse = true; 
        public static bool ShowSettingsAbout = false; 
        public static bool ShowSettingsDeleteAccount = true; 
         
        public static bool ShowSettingsUpdateManagerApp = false; 

        public static bool ShowTextWithSpace = true; 
         
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
        public static bool ShowStore = false;  
        public static bool ShowStations = false;  
        public static bool ShowPlaylist = true;
        public static bool ShowEvent = false; //#New
        public static bool ShowProduct = false; //#New
        public static bool ShowAdvertise = false; //#New

        //Offline Sound >>  
        //*********************************************************
        public static bool AllowOfflineDownload = true;
         
        //Profile >>  
        //*********************************************************
        public static bool ShowEmail = true; 

        public static bool ShowForwardTrack = true; 
        public static bool ShowBackwardTrack = true; 

        //Settings Page >>  
        //*********************************************************
        public static bool ShowEditPassword = true; 
        public static bool ShowWithdrawals = false; 
        public static bool ShowGoPro = false; 
        public static bool ShowBlockedUsers = false; 
        public static bool ShowBlog = false;  
        public static bool ShowSettingsTwoFactor = true;
        public static bool ShowTheme = false;
        public static bool ShowSettingsManageSessions = false;


        //Last_Messages Page >>
        //********************************************************* 
        public static bool RunSoundControl = true; 
        public static int RefreshAppAPiSeconds = 6000; // 6 Seconds
        public static int MessageRequestSpeed = 3000; // 3 Seconds

        //Set Theme App >> Color - Tab
        //*********************************************************
        public static TabTheme SetTabDarkTheme = TabTheme.Dark;

        //Bypass Web Erros 
        //*********************************************************
        public static bool TurnTrustFailureOnWebException = true;
        public static bool TurnSecurityProtocolType3072On = true;

        //*********************************************************
        public static bool RenderPriorityFastPostLoad = true;

        //Payment System
        //*********************************************************
        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// <uses-permission android:name="com.android.vending.BILLING" />
        /// </summary>
        public static bool ShowInAppBilling = false;

        /// <summary>
        /// Paypal and google pay using Braintree Gateway https://www.braintreepayments.com/
        /// 
        /// Add info keys in Payment Methods : https://prnt.sc/1z5bffc & https://prnt.sc/1z5b0yj
        /// To find your merchant ID :  https://prnt.sc/1z59dy8
        ///
        /// Tokenization Keys : https://prnt.sc/1z59smv
        /// </summary>
        public static bool ShowPaypal = false;
        public static string MerchantAccountId = "test"; 

        public static string SandboxTokenizationKey = "sandbox_kt2f6mdh_hf4c******"; 
        public static string ProductionTokenizationKey = "production_t2wns2y2_dfy45******";  

        public static bool ShowBankTransfer = false;
        public static bool ShowCreditCard = false; 
         
        public static bool ShowCashFree = false;

        /// <summary>
        /// Currencies : http://prntscr.com/u600ok
        /// </summary>
        public static string CashFreeCurrency = "INR";
         
        /// <summary>
        /// If you want RazorPay you should change id key in the analytic.xml file
        /// razorpay_api_Key >> .. line 24 
        /// </summary>
        public static bool ShowRazorPay = false;

        /// <summary>
        /// Currencies : https://razorpay.com/accept-international-payments
        /// </summary>
        public static string RazorPayCurrency = "USD";

        public static bool ShowPayStack = false;
        public static bool ShowPaySera = false;

        public static bool ShowPayUmoney = false;
        public static bool ShowAuthorizeNet = false;
        public static bool ShowSecurionPay = false;
        public static bool ShowIyziPay = false;//#New
        public static bool ShowAamarPay = false;//#New

        //********************************************************* 
        public static bool AllowDeletingDownloadedSongs = true; 

        
    }
} 