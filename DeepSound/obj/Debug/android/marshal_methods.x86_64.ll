; ModuleID = 'obj/Debug/android/marshal_methods.x86_64.ll'
source_filename = "obj/Debug/android/marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [210 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 2
	i64 232391251801502327, ; 1: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 91
	i64 295915112840604065, ; 2: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 30
	i64 491883881690734623, ; 3: CircleButton => 0x6d385c8c6eaa01f => 51
	i64 681212437947184707, ; 4: Xamarin.Bindings.AndroidXSlidingUpPanel.dll => 0x974271a646b7643 => 94
	i64 687654259221141486, ; 5: Xamarin.GooglePlayServices.Base => 0x98b09e7c92917ee => 100
	i64 872800313462103108, ; 6: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 18
	i64 943650302560566006, ; 7: ExoPlayer.Dash.dll => 0xd1884f3544ffaf6 => 54
	i64 964003131647442271, ; 8: HtmlAgilityPack => 0xd60d3bda035bd5f => 62
	i64 1000557547492888992, ; 9: Mono.Security.dll => 0xde2b1c9cba651a0 => 41
	i64 1120440138749646132, ; 10: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 35
	i64 1148976814312730096, ; 11: FacebookCore => 0xff1fc5338452df0 => 59
	i64 1301485588176585670, ; 12: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 82
	i64 1400031058434376889, ; 13: Plugin.Permissions.dll => 0x136de8d4787ec4b9 => 74
	i64 1425944114962822056, ; 14: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 39
	i64 1518315023656898250, ; 15: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 83
	i64 1624659445732251991, ; 16: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 10
	i64 1637067789214310945, ; 17: AutoMapper.dll => 0x16b8087b115a6221 => 46
	i64 1731380447121279447, ; 18: Newtonsoft.Json => 0x18071957e9b889d7 => 67
	i64 1795316252682057001, ; 19: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 11
	i64 1836611346387731153, ; 20: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 91
	i64 1916241207282215921, ; 21: AamarPay.dll => 0x1a97db39b005abf1 => 42
	i64 1981742497975770890, ; 22: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 24
	i64 2133195048986300728, ; 23: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 67
	i64 2165725771938924357, ; 24: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 12
	i64 2166422692859749070, ; 25: BraintreeDropIn.dll => 0x1e10adf6014022ce => 50
	i64 2262844636196693701, ; 26: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 18
	i64 2329709569556905518, ; 27: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 22
	i64 2470498323731680442, ; 28: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 14
	i64 2547086958574651984, ; 29: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 90
	i64 2592350477072141967, ; 30: System.Xml.dll => 0x23f9e10627330e8f => 9
	i64 2624866290265602282, ; 31: mscorlib.dll => 0x246d65fbde2db8ea => 4
	i64 2694427813909235223, ; 32: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 28
	i64 2801558180824670388, ; 33: Plugin.CurrentActivity.dll => 0x26e1225279a4e0b4 => 72
	i64 2831516226410177188, ; 34: BrainTreeCardForm.dll => 0x274b910182eee2a4 => 48
	i64 2871876775452277128, ; 35: DeepSound => 0x27daf4b61f86f988 => 104
	i64 2950045609555153781, ; 36: Refractored.Controls.CircleImageView => 0x28f0aada14bc5375 => 77
	i64 2954987430423977617, ; 37: Xamarin.GooglePlayServices.Auth.Base => 0x290239696a2a5e91 => 98
	i64 3017704767998173186, ; 38: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 35
	i64 3171992396844006720, ; 39: Square.OkIO => 0x2c052e476c207d40 => 85
	i64 3289520064315143713, ; 40: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 21
	i64 3364695309916733813, ; 41: Xamarin.Firebase.Common => 0x2eb1cc8eb5028175 => 96
	i64 3397747728761535915, ; 42: HtmlAgilityPack.dll => 0x2f27398ea938bdab => 62
	i64 3411255996856937470, ; 43: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 101
	i64 3522470458906976663, ; 44: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 31
	i64 3531994851595924923, ; 45: System.Numerics => 0x31042a9aade235bb => 8
	i64 3609787854626478660, ; 46: Plugin.CurrentActivity => 0x32188aeda587da44 => 72
	i64 3727469159507183293, ; 47: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 29
	i64 3771425978306366038, ; 48: AamarPay => 0x3456cbf205a18a56 => 42
	i64 4122156692839871744, ; 49: Ongakuer.CircleIndicator.dll => 0x3934d7ac09383500 => 69
	i64 4247996603072512073, ; 50: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 103
	i64 4286851496287849734, ; 51: DeepSoundClient => 0x3b7df4b92116cd06 => 52
	i64 4337444564132831293, ; 52: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 81
	i64 4636684751163556186, ; 53: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 33
	i64 4708653840312162517, ; 54: Square.OkHttp3 => 0x41587fb86215d8d5 => 84
	i64 4759461199762736555, ; 55: Xamarin.AndroidX.Lifecycle.Process.dll => 0x420d00be961cc5ab => 23
	i64 4794310189461587505, ; 56: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 90
	i64 4795410492532947900, ; 57: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 31
	i64 5008703643365249978, ; 58: Razorpay => 0x45827d6d27fd93ba => 76
	i64 5114614535548409624, ; 59: MaterialProgressBar.dll => 0x46fac2d25a699718 => 65
	i64 5203618020066742981, ; 60: Xamarin.Essentials => 0x4836f704f0e652c5 => 95
	i64 5258427006098912452, ; 61: Xamarin.GooglePlayServices.Auth.Base.dll => 0x48f9af806fd8b4c4 => 98
	i64 5348796042099802469, ; 62: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 26
	i64 5408338804355907810, ; 63: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 32
	i64 5507995362134886206, ; 64: System.Core.dll => 0x4c705499688c873e => 5
	i64 5563049671862343767, ; 65: Xamarin.AndroidX.Palette.dll => 0x4d33ec33c7355857 => 27
	i64 5692067934154308417, ; 66: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 92
	i64 5703838680789880885, ; 67: ExoPlayer.SmoothStreaming.dll => 0x4f281b0f589d1035 => 56
	i64 5724799082821825042, ; 68: Xamarin.AndroidX.ExifInterface => 0x4f72926f3e13b212 => 19
	i64 5785798824923173791, ; 69: BrainTree.dll => 0x504b4960756b139f => 47
	i64 5814345312393086621, ; 70: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 28
	i64 5816277333908220299, ; 71: Ongakuer.CircleIndicator => 0x50b7916b52c1698b => 69
	i64 5824193524347257577, ; 72: Xamarin.Android.Google.BillingClient => 0x50d3b12709d942e9 => 89
	i64 6183170893902868313, ; 73: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 81
	i64 6401687960814735282, ; 74: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 22
	i64 6504860066809920875, ; 75: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 12
	i64 6548213210057960872, ; 76: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 17
	i64 6597152804937602598, ; 77: ExoPlayer.Dash => 0x5b8dcb85db471626 => 54
	i64 6876862101832370452, ; 78: System.Xml.Linq => 0x5f6f85a57d108914 => 40
	i64 6900872857064172610, ; 79: DeepSound.dll => 0x5fc4d34d1571ec42 => 104
	i64 7141281584637745974, ; 80: Xamarin.GooglePlayServices.Maps.dll => 0x631aedc3dd5f1b36 => 102
	i64 7161206143302889109, ; 81: BrainTreeCore.dll => 0x6361b70baee9ee95 => 49
	i64 7350757953601002553, ; 82: BrainTree => 0x66032369ae43dc39 => 47
	i64 7488575175965059935, ; 83: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 40
	i64 7637365915383206639, ; 84: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 95
	i64 7643296227074841789, ; 85: MaterialProgressBar => 0x6a12716c2fe11cbd => 65
	i64 7654504624184590948, ; 86: System.Net.Http => 0x6a3a4366801b8264 => 7
	i64 7731117178672402408, ; 87: Xamarin.GooglePlayServices.Ads.Lite.dll => 0x6b4a721cdfb04fe8 => 97
	i64 7735176074855944702, ; 88: Microsoft.CSharp => 0x6b58dda848e391fe => 1
	i64 7735352534559001595, ; 89: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 37
	i64 7820441508502274321, ; 90: System.Data => 0x6c87ca1e14ff8111 => 38
	i64 7836164640616011524, ; 91: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 10
	i64 7875371864198757046, ; 92: AndHUD.dll => 0x6d4af0fc27ac3ab6 => 44
	i64 7887534324349149731, ; 93: MaterialDialogsCore.dll => 0x6d7626ad94882223 => 64
	i64 8003335089973143038, ; 94: Square.OkHttp3.dll => 0x6f118edc6044a5fe => 84
	i64 8083354569033831015, ; 95: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 21
	i64 8167236081217502503, ; 96: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 0
	i64 8277886878735836546, ; 97: AutoMapper => 0x72e0f64211eaa582 => 46
	i64 8426919725312979251, ; 98: Xamarin.AndroidX.Lifecycle.Process => 0x74f26ed7aa033133 => 23
	i64 8479866540936208598, ; 99: IyziPay.dll => 0x75ae89b0d33920d6 => 63
	i64 8601935802264776013, ; 100: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 32
	i64 8609060182490045521, ; 101: Square.OkIO.dll => 0x7779869f8b475c51 => 85
	i64 8626175481042262068, ; 102: Java.Interop => 0x77b654e585b55834 => 0
	i64 8638972117149407195, ; 103: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 1
	i64 8690461831448123647, ; 104: ExoPlayer.Hls => 0x789ab8fddd8e58ff => 55
	i64 8700910800625632289, ; 105: FacebookLogin => 0x78bfd84615a68421 => 60
	i64 8734746097903247398, ; 106: Xamarin.Android.Google.BillingClient.dll => 0x79380d4c20c0a026 => 89
	i64 8859674150081245380, ; 107: BrainTreeCore => 0x7af3e2b2ed4db0c4 => 49
	i64 8870982639326708239, ; 108: IyziPay => 0x7b1c0fb5c1b9c20f => 63
	i64 8877476080266037614, ; 109: Naxam.Stripe.Droid => 0x7b332175ca48c96e => 66
	i64 8932581277669290066, ; 110: SplashScreenCore.dll => 0x7bf6e7585ec87052 => 79
	i64 9062401712863827492, ; 111: FacebookLogin.dll => 0x7dc41e57db23d624 => 60
	i64 9063278072728717678, ; 112: Xamarin.BadgeView => 0x7dc73b634995096e => 93
	i64 9176340846735621919, ; 113: DeepSoundClient.dll => 0x7f58e961bb957f1f => 52
	i64 9225789786819666723, ; 114: ExoPlayer.SmoothStreaming => 0x800896ee47d02323 => 56
	i64 9312692141327339315, ; 115: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 92
	i64 9324707631942237306, ; 116: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 11
	i64 9662334977499516867, ; 117: System.Numerics.dll => 0x8617827802b0cfc3 => 8
	i64 9678050649315576968, ; 118: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 14
	i64 9711637524876806384, ; 119: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 26
	i64 9722368759809762166, ; 120: ExoPlayer.Core => 0x86eccae02fd0e376 => 53
	i64 9729942496004268400, ; 121: AdColonySdk.dll => 0x8707b3260f4fe170 => 43
	i64 9780723996889434231, ; 122: AndHUD => 0x87bc1ca798bbc877 => 44
	i64 9808709177481450983, ; 123: Mono.Android.dll => 0x881f890734e555e7 => 2
	i64 9875200773399460291, ; 124: Xamarin.GooglePlayServices.Base.dll => 0x890bc2c8482339c3 => 100
	i64 9944345468791389265, ; 125: ExoPlayer.Core.dll => 0x8a01698437137c51 => 53
	i64 9998632235833408227, ; 126: Mono.Security => 0x8ac2470b209ebae3 => 41
	i64 10038780035334861115, ; 127: System.Net.Http.dll => 0x8b50e941206af13b => 7
	i64 10078351459017364956, ; 128: Xamarin.GooglePlayServices.Ads.Lite => 0x8bdd7f412c4515dc => 97
	i64 10229024438826829339, ; 129: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 17
	i64 10321854143672141184, ; 130: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 36
	i64 10430153318873392755, ; 131: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 15
	i64 11023048688141570732, ; 132: System.Core => 0x98f9bc61168392ac => 5
	i64 11037814507248023548, ; 133: System.Xml => 0x992e31d0412bf7fc => 9
	i64 11162124722117608902, ; 134: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 34
	i64 11237162742616054720, ; 135: Polly => 0x9bf26bfa34e25bc0 => 75
	i64 11340910727871153756, ; 136: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 16
	i64 11446671985764974897, ; 137: Mono.Android.Export => 0x9edabf8623efc131 => 3
	i64 11529969570048099689, ; 138: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 34
	i64 11697766792743994556, ; 139: TutorialsAndroid.SEmojis.dll => 0xa256d0ebaaddc4bc => 87
	i64 11724931932191659106, ; 140: Xamarin.AndroidX.Palette => 0xa2b7537891eb1462 => 27
	i64 11739066727115742305, ; 141: SQLite-net.dll => 0xa2e98afdf8575c61 => 80
	i64 11806260347154423189, ; 142: SQLite-net => 0xa3d8433bc5eb5d95 => 80
	i64 11858850672355513752, ; 143: FacebookCommon => 0xa49319db0a271598 => 58
	i64 12000919460933314250, ; 144: OneSignalAndroid.dll => 0xa68bd4aa8700a6ca => 68
	i64 12013962889899020729, ; 145: Xamarin.GooglePlayServices.Auth => 0xa6ba2b987d2811b9 => 99
	i64 12079901233369624266, ; 146: FacebookAudienceNetwork.dll => 0xa7a46e2b70ccaeca => 57
	i64 12191646537372739477, ; 147: Xamarin.Android.Glide.dll => 0xa9316dee7f392795 => 88
	i64 12279246230491828964, ; 148: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 83
	i64 12451044538927396471, ; 149: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 20
	i64 12464749468643172684, ; 150: Xamarin.BadgeView.dll => 0xacfbaf99c4b7214c => 93
	i64 12466513435562512481, ; 151: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 25
	i64 12501328358063843848, ; 152: Plugin.Geolocator.dll => 0xad7da3e822e9aa08 => 73
	i64 12538491095302438457, ; 153: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 13
	i64 12582359032369227651, ; 154: PayPalOneTouch => 0xae9d84e030cba783 => 70
	i64 12595796834083980704, ; 155: SplashScreenCore => 0xaecd427c3690c5a0 => 79
	i64 12738569972557874568, ; 156: AdColonySdk => 0xb0c87de5f0c50588 => 43
	i64 12755045860145608087, ; 157: Xamarin.Bindings.AndroidXSlidingUpPanel => 0xb10306a173cbb597 => 94
	i64 12755235034249821636, ; 158: PlayCore => 0xb103b2aefb13fdc4 => 71
	i64 12789891111338843169, ; 159: FacebookCommon.dll => 0xb17ed233b7471c21 => 58
	i64 13010172215566198050, ; 160: Refractored.Controls.CircleImageView.dll => 0xb48d6ab2ff7ae522 => 77
	i64 13370592475155966277, ; 161: System.Runtime.Serialization => 0xb98de304062ea945 => 39
	i64 13465488254036897740, ; 162: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 37
	i64 13537486930159294674, ; 163: SecurionPay => 0xbbded0a367a358d2 => 78
	i64 13542538604934327170, ; 164: BraintreeDropIn => 0xbbf0c31c181feb82 => 50
	i64 13559426415277931074, ; 165: BrainTreeCardForm => 0xbc2cc27bd8b07a42 => 48
	i64 13572454107664307259, ; 166: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 29
	i64 13620541960650004027, ; 167: TutorialsAndroid.SEmojis => 0xbd05e2bf9cd8963b => 87
	i64 13647894001087880694, ; 168: System.Data.dll => 0xbd670f48cb071df6 => 38
	i64 13718695413998651566, ; 169: Naxam.Stripe.Droid.dll => 0xbe6298cb552b88ae => 66
	i64 13740931416259775489, ; 170: FacebookCore.dll => 0xbeb198520d2b4c01 => 59
	i64 13959074834287824816, ; 171: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 20
	i64 13982638193275851912, ; 172: ExoPlayer.Hls.dll => 0xc20c4f5a85045488 => 55
	i64 14124974489674258913, ; 173: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 13
	i64 14310169286812146509, ; 174: Razorpay.dll => 0xc697ef25d8249b4d => 76
	i64 14789919016435397935, ; 175: Xamarin.Firebase.Common.dll => 0xcd4058fc2f6d352f => 96
	i64 14852515768018889994, ; 176: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 16
	i64 14889905118082851278, ; 177: GoogleGson.dll => 0xcea391d0969961ce => 61
	i64 14932149064186299217, ; 178: PlayCore.dll => 0xcf39a675c0018351 => 71
	i64 15370334346939861994, ; 179: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 15
	i64 15380476276999939641, ; 180: ArthurHub.AndroidImageCropper.dll => 0xd5726daf46e76639 => 45
	i64 15531716208086575713, ; 181: ArthurHub.AndroidImageCropper => 0xd78bbd99c72d6a61 => 45
	i64 15609085926864131306, ; 182: System.dll => 0xd89e9cf3334914ea => 6
	i64 15777549416145007739, ; 183: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 30
	i64 15930129725311349754, ; 184: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 103
	i64 15949253906898472765, ; 185: TextDrawable => 0xdd5721ecf131cf3d => 86
	i64 16154507427712707110, ; 186: System => 0xe03056ea4e39aa26 => 6
	i64 16278354803554930261, ; 187: SecurionPay.dll => 0xe1e8557289aa4e55 => 78
	i64 16361933716545543812, ; 188: Xamarin.AndroidX.ExifInterface.dll => 0xe3114406a52f1e84 => 19
	i64 16496768397145114574, ; 189: Mono.Android.Export.dll => 0xe4f04b741db987ce => 3
	i64 16755018182064898362, ; 190: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 82
	i64 16833383113903931215, ; 191: mscorlib => 0xe99c30c1484d7f4f => 4
	i64 16842710208862012885, ; 192: CircleButton.dll => 0xe9bd53b2ce10c5d5 => 51
	i64 16895806301542741427, ; 193: Plugin.Permissions => 0xea79f6503d42f5b3 => 74
	i64 16927880089487044255, ; 194: PayPalOneTouch.dll => 0xeaebe940ee486e9f => 70
	i64 16957274737478375326, ; 195: OneSignalAndroid => 0xeb545787be1a979e => 68
	i64 17310799966561153083, ; 196: Xamarin.GooglePlayServices.Auth.dll => 0xf03c50da60b8b03b => 99
	i64 17490387529020045715, ; 197: MaterialDialogsCore => 0xf2ba56ca23297993 => 64
	i64 17522591619082469157, ; 198: GoogleGson => 0xf32cc03d27a5bf25 => 61
	i64 17590473451926037903, ; 199: Xamarin.Android.Glide => 0xf41dea67fcfda58f => 88
	i64 17675249797910273188, ; 200: Polly.dll => 0xf54b1a0b30bc9ca4 => 75
	i64 17704177640604968747, ; 201: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 25
	i64 17710060891934109755, ; 202: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 24
	i64 17786996386789405829, ; 203: Plugin.Geolocator => 0xf6d81af967bd3485 => 73
	i64 17891337867145587222, ; 204: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 36
	i64 17969331831154222830, ; 205: Xamarin.GooglePlayServices.Maps => 0xf95fe418471126ee => 102
	i64 17986907704309214542, ; 206: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 101
	i64 18150681500308114417, ; 207: FacebookAudienceNetwork => 0xfbe42ca8791e8bf1 => 57
	i64 18380184030268848184, ; 208: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 33
	i64 18436943062401560267 ; 209: TextDrawable.dll => 0xffdd2e083a8c2ecb => 86
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [210 x i32] [
	i32 2, i32 91, i32 30, i32 51, i32 94, i32 100, i32 18, i32 54, ; 0..7
	i32 62, i32 41, i32 35, i32 59, i32 82, i32 74, i32 39, i32 83, ; 8..15
	i32 10, i32 46, i32 67, i32 11, i32 91, i32 42, i32 24, i32 67, ; 16..23
	i32 12, i32 50, i32 18, i32 22, i32 14, i32 90, i32 9, i32 4, ; 24..31
	i32 28, i32 72, i32 48, i32 104, i32 77, i32 98, i32 35, i32 85, ; 32..39
	i32 21, i32 96, i32 62, i32 101, i32 31, i32 8, i32 72, i32 29, ; 40..47
	i32 42, i32 69, i32 103, i32 52, i32 81, i32 33, i32 84, i32 23, ; 48..55
	i32 90, i32 31, i32 76, i32 65, i32 95, i32 98, i32 26, i32 32, ; 56..63
	i32 5, i32 27, i32 92, i32 56, i32 19, i32 47, i32 28, i32 69, ; 64..71
	i32 89, i32 81, i32 22, i32 12, i32 17, i32 54, i32 40, i32 104, ; 72..79
	i32 102, i32 49, i32 47, i32 40, i32 95, i32 65, i32 7, i32 97, ; 80..87
	i32 1, i32 37, i32 38, i32 10, i32 44, i32 64, i32 84, i32 21, ; 88..95
	i32 0, i32 46, i32 23, i32 63, i32 32, i32 85, i32 0, i32 1, ; 96..103
	i32 55, i32 60, i32 89, i32 49, i32 63, i32 66, i32 79, i32 60, ; 104..111
	i32 93, i32 52, i32 56, i32 92, i32 11, i32 8, i32 14, i32 26, ; 112..119
	i32 53, i32 43, i32 44, i32 2, i32 100, i32 53, i32 41, i32 7, ; 120..127
	i32 97, i32 17, i32 36, i32 15, i32 5, i32 9, i32 34, i32 75, ; 128..135
	i32 16, i32 3, i32 34, i32 87, i32 27, i32 80, i32 80, i32 58, ; 136..143
	i32 68, i32 99, i32 57, i32 88, i32 83, i32 20, i32 93, i32 25, ; 144..151
	i32 73, i32 13, i32 70, i32 79, i32 43, i32 94, i32 71, i32 58, ; 152..159
	i32 77, i32 39, i32 37, i32 78, i32 50, i32 48, i32 29, i32 87, ; 160..167
	i32 38, i32 66, i32 59, i32 20, i32 55, i32 13, i32 76, i32 96, ; 168..175
	i32 16, i32 61, i32 71, i32 15, i32 45, i32 45, i32 6, i32 30, ; 176..183
	i32 103, i32 86, i32 6, i32 78, i32 19, i32 3, i32 82, i32 4, ; 184..191
	i32 51, i32 74, i32 70, i32 68, i32 99, i32 64, i32 61, i32 88, ; 192..199
	i32 75, i32 25, i32 24, i32 73, i32 36, i32 102, i32 101, i32 57, ; 200..207
	i32 33, i32 86 ; 208..209
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
