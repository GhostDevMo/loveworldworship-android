; ModuleID = 'obj/Debug/android/marshal_methods.armeabi-v7a.ll'
source_filename = "obj/Debug/android/marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [210 x i32] [
	i32 39109920, ; 0: Newtonsoft.Json.dll => 0x254c520 => 67
	i32 39852199, ; 1: Plugin.Permissions => 0x26018a7 => 74
	i32 52239042, ; 2: HtmlAgilityPack => 0x31d1ac2 => 62
	i32 73948118, ; 3: TutorialsAndroid.SEmojis => 0x4685bd6 => 87
	i32 86237159, ; 4: OneSignalAndroid.dll => 0x523dfe7 => 68
	i32 101534019, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 30
	i32 120558881, ; 6: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 30
	i32 174211662, ; 7: IyziPay.dll => 0xa62424e => 63
	i32 182336117, ; 8: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 31
	i32 209399409, ; 9: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 12
	i32 219316277, ; 10: AamarPay.dll => 0xd128035 => 42
	i32 230752869, ; 11: Microsoft.CSharp.dll => 0xdc10265 => 1
	i32 267364771, ; 12: MaterialProgressBar.dll => 0xfefa9a3 => 65
	i32 293579439, ; 13: ExoPlayer.Dash.dll => 0x117faaaf => 54
	i32 318968648, ; 14: Xamarin.AndroidX.Activity.dll => 0x13031348 => 90
	i32 321597661, ; 15: System.Numerics => 0x132b30dd => 8
	i32 322975647, ; 16: CircleButton.dll => 0x1340379f => 51
	i32 342366114, ; 17: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 21
	i32 361599777, ; 18: Xamarin.BadgeView.dll => 0x158d9321 => 93
	i32 367124688, ; 19: FacebookCommon => 0x15e1e0d0 => 58
	i32 442521989, ; 20: Xamarin.Essentials => 0x1a605985 => 95
	i32 450948140, ; 21: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 20
	i32 458821065, ; 22: Xamarin.GooglePlayServices.Ads.Lite => 0x1b590dc9 => 97
	i32 465846621, ; 23: mscorlib => 0x1bc4415d => 4
	i32 469710990, ; 24: System.dll => 0x1bff388e => 6
	i32 566179819, ; 25: ArthurHub.AndroidImageCropper.dll => 0x21bf37eb => 45
	i32 627609679, ; 26: Xamarin.AndroidX.CustomView => 0x2568904f => 17
	i32 663517072, ; 27: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 33
	i32 690569205, ; 28: System.Xml.Linq.dll => 0x29293ff5 => 40
	i32 691747444, ; 29: BrainTree => 0x293b3a74 => 47
	i32 700284507, ; 30: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 36
	i32 738344596, ; 31: AamarPay => 0x2c023e94 => 42
	i32 748832960, ; 32: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 81
	i32 782705059, ; 33: Xamarin.Android.Google.BillingClient.dll => 0x2ea721a3 => 89
	i32 812693636, ; 34: ExoPlayer.Dash => 0x3070b884 => 54
	i32 844630841, ; 35: SplashScreenCore.dll => 0x32580b39 => 79
	i32 893593324, ; 36: Xamarin.GooglePlayServices.Ads.Lite.dll => 0x354326ec => 97
	i32 955402788, ; 37: Newtonsoft.Json => 0x38f24a24 => 67
	i32 957807352, ; 38: Plugin.CurrentActivity => 0x3916faf8 => 72
	i32 961995525, ; 39: Square.OkIO.dll => 0x3956e305 => 85
	i32 967690846, ; 40: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 21
	i32 1012816738, ; 41: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 91
	i32 1034577869, ; 42: Refractored.Controls.CircleImageView => 0x3daa67cd => 77
	i32 1035644815, ; 43: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 11
	i32 1040795281, ; 44: IyziPay => 0x3e094691 => 63
	i32 1052210849, ; 45: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 24
	i32 1067306892, ; 46: GoogleGson => 0x3f9dcf8c => 61
	i32 1084122840, ; 47: Xamarin.Kotlin.StdLib => 0x409e66d8 => 37
	i32 1098259244, ; 48: System => 0x41761b2c => 6
	i32 1118795402, ; 49: MaterialDialogsCore => 0x42af768a => 64
	i32 1127295045, ; 50: Polly.dll => 0x43312845 => 75
	i32 1137654822, ; 51: Plugin.Permissions.dll => 0x43cf3c26 => 74
	i32 1221286664, ; 52: Square.OkHttp3 => 0x48cb5b08 => 84
	i32 1256819732, ; 53: Razorpay => 0x4ae98c14 => 76
	i32 1276127029, ; 54: Ongakuer.CircleIndicator => 0x4c102735 => 69
	i32 1282958517, ; 55: Plugin.Geolocator => 0x4c7864b5 => 73
	i32 1285679178, ; 56: AdColonySdk.dll => 0x4ca1e84a => 43
	i32 1292207520, ; 57: SQLitePCLRaw.core.dll => 0x4d0585a0 => 82
	i32 1293217323, ; 58: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 18
	i32 1333047053, ; 59: Xamarin.Firebase.Common => 0x4f74af0d => 96
	i32 1376866003, ; 60: Xamarin.AndroidX.SavedState => 0x52114ed3 => 91
	i32 1395857551, ; 61: Xamarin.AndroidX.Media.dll => 0x5333188f => 26
	i32 1406073936, ; 62: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 14
	i32 1452416952, ; 63: AutoMapper => 0x56921fb8 => 46
	i32 1469204771, ; 64: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 10
	i32 1488767841, ; 65: TextDrawable.dll => 0x58bccb61 => 86
	i32 1521295448, ; 66: FacebookLogin => 0x5aad2058 => 60
	i32 1574037382, ; 67: Xamarin.Android.Google.BillingClient => 0x5dd1e786 => 89
	i32 1592978981, ; 68: System.Runtime.Serialization.dll => 0x5ef2ee25 => 39
	i32 1622152042, ; 69: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 25
	i32 1624863272, ; 70: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 92
	i32 1636350590, ; 71: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 16
	i32 1639515021, ; 72: System.Net.Http.dll => 0x61b9038d => 7
	i32 1658251792, ; 73: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 35
	i32 1672688034, ; 74: FacebookAudienceNetwork => 0x63b331a2 => 57
	i32 1684375249, ; 75: CircleButton => 0x646586d1 => 51
	i32 1729485958, ; 76: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 13
	i32 1746316138, ; 77: Mono.Android.Export => 0x6816ab6a => 3
	i32 1765620304, ; 78: ExoPlayer.Core => 0x693d3a50 => 53
	i32 1766324549, ; 79: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 31
	i32 1776026572, ; 80: System.Core.dll => 0x69dc03cc => 5
	i32 1776229709, ; 81: FacebookAudienceNetwork.dll => 0x69df1d4d => 57
	i32 1788241197, ; 82: Xamarin.AndroidX.Fragment => 0x6a96652d => 20
	i32 1808609942, ; 83: Xamarin.AndroidX.Loader => 0x6bcd3296 => 25
	i32 1813058853, ; 84: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 37
	i32 1813201214, ; 85: Xamarin.Google.Android.Material => 0x6c13413e => 35
	i32 1867746548, ; 86: Xamarin.Essentials.dll => 0x6f538cf4 => 95
	i32 1906990320, ; 87: DeepSound.dll => 0x71aa5cf0 => 104
	i32 1908813208, ; 88: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 101
	i32 1970871209, ; 89: BraintreeDropIn => 0x75791ba9 => 50
	i32 2019465201, ; 90: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 24
	i32 2031445118, ; 91: AutoMapper.dll => 0x7915647e => 46
	i32 2031763787, ; 92: Xamarin.Android.Glide => 0x791a414b => 88
	i32 2051831635, ; 93: TextDrawable => 0x7a4c7753 => 86
	i32 2055257422, ; 94: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 22
	i32 2095474518, ; 95: Xamarin.GooglePlayServices.Auth.Base => 0x7ce66756 => 98
	i32 2103459038, ; 96: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 83
	i32 2129483829, ; 97: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 100
	i32 2156766828, ; 98: Refractored.Controls.CircleImageView.dll => 0x808da66c => 77
	i32 2201231467, ; 99: System.Net.Http => 0x8334206b => 7
	i32 2239138732, ; 100: ExoPlayer.SmoothStreaming => 0x85768bac => 56
	i32 2242368566, ; 101: Xamarin.Bindings.AndroidXSlidingUpPanel.dll => 0x85a7d436 => 94
	i32 2279755925, ; 102: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 29
	i32 2306030423, ; 103: ArthurHub.AndroidImageCropper => 0x89733b57 => 45
	i32 2345716545, ; 104: BrainTreeCore.dll => 0x8bd0cb41 => 49
	i32 2363138611, ; 105: FacebookLogin.dll => 0x8cdaa233 => 60
	i32 2409053734, ; 106: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 28
	i32 2416103931, ; 107: DeepSoundClient.dll => 0x9002d1fb => 52
	i32 2422216757, ; 108: Naxam.Stripe.Droid.dll => 0x90601835 => 66
	i32 2465273461, ; 109: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 81
	i32 2469124927, ; 110: DeepSound => 0x932bdb3f => 104
	i32 2475788418, ; 111: Java.Interop.dll => 0x93918882 => 0
	i32 2499817014, ; 112: Naxam.Stripe.Droid => 0x95002e36 => 66
	i32 2518430301, ; 113: DeepSoundClient => 0x961c325d => 52
	i32 2521515918, ; 114: BrainTree.dll => 0x964b478e => 47
	i32 2522472828, ; 115: Xamarin.Android.Glide.dll => 0x9659e17c => 88
	i32 2562349572, ; 116: Microsoft.CSharp => 0x98ba5a04 => 1
	i32 2563143864, ; 117: AndHUD.dll => 0x98c678b8 => 44
	i32 2620871830, ; 118: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 16
	i32 2713040075, ; 119: ExoPlayer.Hls => 0xa1b5b4cb => 55
	i32 2732626843, ; 120: Xamarin.AndroidX.Activity => 0xa2e0939b => 90
	i32 2737747696, ; 121: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 10
	i32 2739685929, ; 122: Xamarin.Bindings.AndroidXSlidingUpPanel => 0xa34c4a29 => 94
	i32 2770495804, ; 123: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 36
	i32 2772484381, ; 124: Xamarin.AndroidX.Palette.dll => 0xa540c11d => 27
	i32 2778768386, ; 125: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 34
	i32 2806986428, ; 126: Plugin.CurrentActivity.dll => 0xa74f36bc => 72
	i32 2810250172, ; 127: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 14
	i32 2816771087, ; 128: SecurionPay => 0xa7e4840f => 78
	i32 2819470561, ; 129: System.Xml.dll => 0xa80db4e1 => 9
	i32 2847418871, ; 130: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 100
	i32 2848218994, ; 131: TutorialsAndroid.SEmojis.dll => 0xa9c45f72 => 87
	i32 2853208004, ; 132: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 34
	i32 2855708567, ; 133: Xamarin.AndroidX.Transition => 0xaa36a797 => 32
	i32 2858253121, ; 134: Razorpay.dll => 0xaa5d7b41 => 76
	i32 2861098320, ; 135: Mono.Android.Export.dll => 0xaa88e550 => 3
	i32 2884993177, ; 136: Xamarin.AndroidX.ExifInterface => 0xabf58099 => 19
	i32 2905242038, ; 137: mscorlib.dll => 0xad2a79b6 => 4
	i32 2916838712, ; 138: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 92
	i32 2943219317, ; 139: Square.OkIO => 0xaf6df675 => 85
	i32 2978675010, ; 140: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 18
	i32 2996846495, ; 141: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 23
	i32 3017076677, ; 142: Xamarin.GooglePlayServices.Maps => 0xb3d4efc5 => 102
	i32 3058099980, ; 143: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 103
	i32 3071899978, ; 144: Xamarin.Firebase.Common.dll => 0xb719794a => 96
	i32 3091256150, ; 145: Ongakuer.CircleIndicator.dll => 0xb840d356 => 69
	i32 3111772706, ; 146: System.Runtime.Serialization => 0xb979e222 => 39
	i32 3126016514, ; 147: Plugin.Geolocator.dll => 0xba533a02 => 73
	i32 3144327419, ; 148: ExoPlayer.Hls.dll => 0xbb6aa0fb => 55
	i32 3145551686, ; 149: Xamarin.BadgeView => 0xbb7d4f46 => 93
	i32 3148237826, ; 150: GoogleGson.dll => 0xbba64c02 => 61
	i32 3191613984, ; 151: OneSignalAndroid => 0xbe3c2a20 => 68
	i32 3204380047, ; 152: System.Data.dll => 0xbefef58f => 38
	i32 3217536604, ; 153: Square.OkHttp3.dll => 0xbfc7b65c => 84
	i32 3230466174, ; 154: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 101
	i32 3247949154, ; 155: Mono.Security => 0xc197c562 => 41
	i32 3258312781, ; 156: Xamarin.AndroidX.CardView => 0xc235e84d => 13
	i32 3286872994, ; 157: SQLite-net.dll => 0xc3e9b3a2 => 80
	i32 3293533752, ; 158: FacebookCommon.dll => 0xc44f5638 => 58
	i32 3312749858, ; 159: BrainTreeCardForm.dll => 0xc5748d22 => 48
	i32 3317135071, ; 160: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 17
	i32 3317144872, ; 161: System.Data => 0xc5b79d28 => 38
	i32 3360279109, ; 162: SQLitePCLRaw.core => 0xc849ca45 => 82
	i32 3362522851, ; 163: Xamarin.AndroidX.Core => 0xc86c06e3 => 15
	i32 3366347497, ; 164: Java.Interop => 0xc8a662e9 => 0
	i32 3369739654, ; 165: Xamarin.AndroidX.Palette => 0xc8da2586 => 27
	i32 3374999561, ; 166: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 29
	i32 3429136800, ; 167: System.Xml => 0xcc6479a0 => 9
	i32 3442543374, ; 168: AndHUD => 0xcd310b0e => 44
	i32 3448896322, ; 169: Polly => 0xcd91fb42 => 75
	i32 3455933041, ; 170: PlayCore => 0xcdfd5a71 => 71
	i32 3465947803, ; 171: Xamarin.GooglePlayServices.Auth.dll => 0xce962a9b => 99
	i32 3476120550, ; 172: Mono.Android => 0xcf3163e6 => 2
	i32 3497266880, ; 173: SplashScreenCore => 0xd0740ec0 => 79
	i32 3509114376, ; 174: System.Xml.Linq => 0xd128d608 => 40
	i32 3552132914, ; 175: BrainTreeCore => 0xd3b93f32 => 49
	i32 3554994536, ; 176: SecurionPay.dll => 0xd3e4e968 => 78
	i32 3618140916, ; 177: Xamarin.AndroidX.Preference => 0xd7a872f4 => 28
	i32 3641597786, ; 178: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 22
	i32 3647750875, ; 179: MaterialProgressBar => 0xd96c42db => 65
	i32 3672681054, ; 180: Mono.Android.dll => 0xdae8aa5e => 2
	i32 3682565725, ; 181: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 12
	i32 3714503948, ; 182: AdColonySdk => 0xdd66d50c => 43
	i32 3729924096, ; 183: Xamarin.GooglePlayServices.Auth => 0xde522000 => 99
	i32 3743546422, ; 184: PayPalOneTouch.dll => 0xdf21fc36 => 70
	i32 3754567612, ; 185: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 83
	i32 3810220126, ; 186: HtmlAgilityPack.dll => 0xe31b585e => 62
	i32 3811901703, ; 187: BraintreeDropIn.dll => 0xe3350107 => 50
	i32 3813027765, ; 188: FacebookCore.dll => 0xe3462fb5 => 59
	i32 3822602673, ; 189: Xamarin.AndroidX.Media => 0xe3d849b1 => 26
	i32 3829621856, ; 190: System.Numerics.dll => 0xe4436460 => 8
	i32 3869667957, ; 191: PayPalOneTouch => 0xe6a67275 => 70
	i32 3876362041, ; 192: SQLite-net => 0xe70c9739 => 80
	i32 3885922214, ; 193: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 32
	i32 3896760992, ; 194: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 15
	i32 3903073087, ; 195: MaterialDialogsCore.dll => 0xe8a42b3f => 64
	i32 3913751325, ; 196: PlayCore.dll => 0xe9471b1d => 71
	i32 3921031405, ; 197: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 33
	i32 3955647286, ; 198: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 11
	i32 3959773229, ; 199: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 23
	i32 3970018735, ; 200: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 103
	i32 3991193666, ; 201: Xamarin.GooglePlayServices.Auth.Base.dll => 0xede4c842 => 98
	i32 4105002889, ; 202: Mono.Security.dll => 0xf4ad5f89 => 41
	i32 4128500484, ; 203: FacebookCore => 0xf613eb04 => 59
	i32 4151237749, ; 204: System.Core => 0xf76edc75 => 5
	i32 4173364138, ; 205: ExoPlayer.SmoothStreaming.dll => 0xf8c07baa => 56
	i32 4190597220, ; 206: ExoPlayer.Core.dll => 0xf9c77064 => 53
	i32 4226044219, ; 207: BrainTreeCardForm => 0xfbe4513b => 48
	i32 4278134329, ; 208: Xamarin.GooglePlayServices.Maps.dll => 0xfeff2639 => 102
	i32 4294763496 ; 209: Xamarin.AndroidX.ExifInterface.dll => 0xfffce3e8 => 19
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [210 x i32] [
	i32 67, i32 74, i32 62, i32 87, i32 68, i32 30, i32 30, i32 63, ; 0..7
	i32 31, i32 12, i32 42, i32 1, i32 65, i32 54, i32 90, i32 8, ; 8..15
	i32 51, i32 21, i32 93, i32 58, i32 95, i32 20, i32 97, i32 4, ; 16..23
	i32 6, i32 45, i32 17, i32 33, i32 40, i32 47, i32 36, i32 42, ; 24..31
	i32 81, i32 89, i32 54, i32 79, i32 97, i32 67, i32 72, i32 85, ; 32..39
	i32 21, i32 91, i32 77, i32 11, i32 63, i32 24, i32 61, i32 37, ; 40..47
	i32 6, i32 64, i32 75, i32 74, i32 84, i32 76, i32 69, i32 73, ; 48..55
	i32 43, i32 82, i32 18, i32 96, i32 91, i32 26, i32 14, i32 46, ; 56..63
	i32 10, i32 86, i32 60, i32 89, i32 39, i32 25, i32 92, i32 16, ; 64..71
	i32 7, i32 35, i32 57, i32 51, i32 13, i32 3, i32 53, i32 31, ; 72..79
	i32 5, i32 57, i32 20, i32 25, i32 37, i32 35, i32 95, i32 104, ; 80..87
	i32 101, i32 50, i32 24, i32 46, i32 88, i32 86, i32 22, i32 98, ; 88..95
	i32 83, i32 100, i32 77, i32 7, i32 56, i32 94, i32 29, i32 45, ; 96..103
	i32 49, i32 60, i32 28, i32 52, i32 66, i32 81, i32 104, i32 0, ; 104..111
	i32 66, i32 52, i32 47, i32 88, i32 1, i32 44, i32 16, i32 55, ; 112..119
	i32 90, i32 10, i32 94, i32 36, i32 27, i32 34, i32 72, i32 14, ; 120..127
	i32 78, i32 9, i32 100, i32 87, i32 34, i32 32, i32 76, i32 3, ; 128..135
	i32 19, i32 4, i32 92, i32 85, i32 18, i32 23, i32 102, i32 103, ; 136..143
	i32 96, i32 69, i32 39, i32 73, i32 55, i32 93, i32 61, i32 68, ; 144..151
	i32 38, i32 84, i32 101, i32 41, i32 13, i32 80, i32 58, i32 48, ; 152..159
	i32 17, i32 38, i32 82, i32 15, i32 0, i32 27, i32 29, i32 9, ; 160..167
	i32 44, i32 75, i32 71, i32 99, i32 2, i32 79, i32 40, i32 49, ; 168..175
	i32 78, i32 28, i32 22, i32 65, i32 2, i32 12, i32 43, i32 99, ; 176..183
	i32 70, i32 83, i32 62, i32 50, i32 59, i32 26, i32 8, i32 70, ; 184..191
	i32 80, i32 32, i32 15, i32 64, i32 71, i32 33, i32 11, i32 23, ; 192..199
	i32 103, i32 98, i32 41, i32 59, i32 5, i32 56, i32 53, i32 48, ; 200..207
	i32 102, i32 19 ; 208..209
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
