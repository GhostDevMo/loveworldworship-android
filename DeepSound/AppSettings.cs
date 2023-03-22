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
        public static string Cert = "/Xx/HSzz9zJ6rj2+MssKMsx5bnO8AwXWBpOKPWgCH3BEspriH4ZpI0YmLaAH/6INI6gVUYdz4c4edV3dYs/BkJhWFe8Srswqj3U193KSsw+oGsIuQ0S7w6igls25s7Jw3San82NRR9ND2x+rJxSl4Pwhhjnqj0xS3IlwKeGkWc7XawY5Q418gsJ1aY7fF8v7idtDoHdbwkd7Ak2Jek0zjkIWtmAE84stAQfAjfP0xk4uAiTJRFHBFOi00HxNWtVz3O3ttp88s81adHrLOsEJZtIzVu9pzTCFno6dZRuM6bXrl8wZCO4+wHjS732eTxHeWVkCWpiCIUrJ1zmSvfaf/oLYEEZWACvn/ImvsxSwdvqKnnwToVaogFUhIMLS7GPhe3EljW7cb9VEjx+qyyCk6FYbNlBST+Uo4hz1cjYwznjkZpT9YXmqIBYRRktap7he9NxnamOhEakmqwduk0/LcR/itKoS8xm18ax4DBPZNqt1mJFz6u9de4JF3U1OgUEtfgcvlYl3Cx1gePKYrfiibcztoDA8fvWQHshTIsAFtcN6ygCZ5K6h8OfBwMkzp6qdc1Uloq2cGQ+40+BgMYmKYE3yIRk4yTaFUdCl3Y9I9SDDknvkRObYDKO6SZAi9RUDZZhxO0WrVrBfo9JMRX8Rk8MNKTXng2GEcbKjt2zKzB3q219x1iYQIB/Y4cWyaCxF93UipkskaEzq20nSp0UFyWrXaWdQa1BJ9DC2Yv1iaDsMQFEAZ4HAtHbiPSh0I5B9FQRwXgZwi2fAhiIk0IIwilTDTwdSk+zC1FQZmNslsXpPRas83/7j8kbOKbBP8ab5eSN9jrKqk6m8jyWOxkGO9JDdcDN97569p3F81sapf+BgLbm92hbIdfUkQQXqAVi4DyeMlXrt5GuN1Lu0Lm3fWhxH0Bo13aMgVhzNmQKKQquADAHBpodJXg8f2llRFJZBwBmg4mTab8WrfVbJZUtfBYYIa1JDtSg6q3bMnh+ieOF3QI+snSGYNcds3x0e+E1q9ZQ1KTBF6ZRJOO3H5X2LH3ZGViKlo9MFwpqZPHaj0yUcq3qQ9SwNqM0wimQzRR4+QbWgXeicQG814E2jZrAaYWb+djjpNzdpeGfxdAVPn/6H6ZlL5Yz3kMSXQEKsOM+L0aHa6WGPcNlgdkfAOvy3eD/OHKSR9mGrHwHn7yLu/sgAsKVcmaC7Lz1QlZ7Q1bu6gwGosZmw+hi5FFbnpMFhCrcVlVnPV7BfqooZPfsLWzTjSEpT67aF1Y2f2oeSTP2HFzd6HeBjqvYCHsIfZen+++SdRs75VLGbhv50ETcK5rR49VyOrX0FD9SRRcG4iowzIQLWF+rEsvvYM2KJGfBZN5rHHpTV5hbmYawzkv8tXFbbAb2kU1tPn0HIWj/BGe4BNpZE4mRqshfsRFeynXNsSDJYjhaceA+HC6ZbwAAAROXNwHkLhzS6Ys9Wp1T3hpCC9h76wj/D+7ON7jgw0LZf03sD6MJrm2oN8fjHYoSaOYUgU2H2bSiYDiBvR16T4rquPN+7cO+PvpnRjHL7BYJenm74QJ4sZUe2qRcCK3bnoU4DxaA6xW7sdtSqGBJ3OiZlkEvUytzD2HbFY+GCHTSpsQoSPGQDjcHb5e8i4WfuQfrQONivXoZ/nX8dSmYUWW0Z1OumpyFXDCvsmBt+UKUh7LdkuTDi2QEG0H0mVHswPMUZbE6uz/O5GXYw3Lu6TZmZe8k9QatNrAwkiu8FLtocUGKTFhvzjOwmp3N0VuubHZjzsGBgZQRMoC/1PY+9R6JPrHS1yKox2TI6nCuKKqa2Ax44YOWqa5x6i7GND1C2k/IxSVqlF8oe/qzB1bH528fq91yhcaXBvN/1qDltfNO+CJggMxLSOcjEpWVwkUEXwLOukJyhyvb9MHforMbsvjBks/NJxmzlhrcDGlts3y1zfm7ZKhMWRFi0BUo1bY33UiNrIri+JLcG7eRYPYYlHTrqY6iLXyueQ4dy3sWDfFcMl6wgUtVyTpy4uDfAs6QYHz4fdZyyqDCNT88fd8x/L7NBwsfH67xCQTIurveC0sMsPVivVU1kc7n+70qdvJuSpXxX5Ro/LiQsIaS7K2ePBAqra0bujuXRWCkx0eFp/ihgGOz5z7at1snpB9cd2fmU6eFaHliAzImBP/tAjwLZjUErAvkKXgye9ZmePk068L/awIOFZ92SC0mrHRVZbBa9QI19gPOIzujTvCkTSreo5xLsmFECd+lFh4Fi9UVkeLTIYhbFMMrmjgrqKwbMTzku7H93YD5jG9MVfYTkOxmp6bJeR1Wrrt8iLs3jE2DCHPYKx/0BRkTU6Fo0+Jrq5g7esoCSY5W0cKv6i3QL/I1LnwWpEkTiQ283xSaNcH45TGx2+eCn2bbfyOPMIzgOJIElEc6NMDRyZ50jI2Guhizlcb3KpSDTATGu8f0t34/WHC+TkElSyRV8x2Qv/+6u2u5iKalhyW+6D+mdj7gVEXhbivdxNBuQRs1duYZ1ylg8oIRvVvstK0J5R6ycpeup7RK3yrMofLSFqKPPxUM0I9IQ3hP+m7Whi8nLj8ImxoeXyvRZctg9TDQ75/HdF5aaeggQGf+wTwkkjixQFgvgajr4AW+uVlg2mx0s3St+p/nOOF4FCF0kfwu859sgbVgkHjuuIrZ6bJgBzllIKORHRsV4lVryQi21buLbChNQQnPkCmSWXt30LsI+5lo+iPG9WRH3YtFtiZJSKm52SSDf4tIU14NUTrIbUwGvHKII+n4v7PjchnYC4ir0j9LsxNtaP8dRQyNzWi0/2hbRNEMXE4D2ZDvo16DFrCkNWO2rlZf+HsaBjHNkbMcYwh8tiYncqXs6P5dGt/WyxZBHjj0Ovqq7r5v0pr3fUZ/NbLg=";
        
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