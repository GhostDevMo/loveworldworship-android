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