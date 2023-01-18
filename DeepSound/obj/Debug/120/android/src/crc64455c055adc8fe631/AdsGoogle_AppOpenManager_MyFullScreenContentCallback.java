package crc64455c055adc8fe631;


public class AdsGoogle_AppOpenManager_MyFullScreenContentCallback
	extends com.google.android.gms.ads.FullScreenContentCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdFailedToShowFullScreenContent:(Lcom/google/android/gms/ads/AdError;)V:GetOnAdFailedToShowFullScreenContent_Lcom_google_android_gms_ads_AdError_Handler\n" +
			"n_onAdShowedFullScreenContent:()V:GetOnAdShowedFullScreenContentHandler\n" +
			"n_onAdDismissedFullScreenContent:()V:GetOnAdDismissedFullScreenContentHandler\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Helpers.Ads.AdsGoogle+AppOpenManager+MyFullScreenContentCallback, DeepSound", AdsGoogle_AppOpenManager_MyFullScreenContentCallback.class, __md_methods);
	}


	public AdsGoogle_AppOpenManager_MyFullScreenContentCallback ()
	{
		super ();
		if (getClass () == AdsGoogle_AppOpenManager_MyFullScreenContentCallback.class)
			mono.android.TypeManager.Activate ("DeepSound.Helpers.Ads.AdsGoogle+AppOpenManager+MyFullScreenContentCallback, DeepSound", "", this, new java.lang.Object[] {  });
	}

	public AdsGoogle_AppOpenManager_MyFullScreenContentCallback (crc64455c055adc8fe631.AdsGoogle_AppOpenManager p0, com.google.android.gms.ads.FullScreenContentCallback p1)
	{
		super ();
		if (getClass () == AdsGoogle_AppOpenManager_MyFullScreenContentCallback.class)
			mono.android.TypeManager.Activate ("DeepSound.Helpers.Ads.AdsGoogle+AppOpenManager+MyFullScreenContentCallback, DeepSound", "DeepSound.Helpers.Ads.AdsGoogle+AppOpenManager, DeepSound:Android.Gms.Ads.FullScreenContentCallback, Xamarin.GooglePlayServices.Ads.Lite", this, new java.lang.Object[] { p0, p1 });
	}


	public void onAdFailedToShowFullScreenContent (com.google.android.gms.ads.AdError p0)
	{
		n_onAdFailedToShowFullScreenContent (p0);
	}

	private native void n_onAdFailedToShowFullScreenContent (com.google.android.gms.ads.AdError p0);


	public void onAdShowedFullScreenContent ()
	{
		n_onAdShowedFullScreenContent ();
	}

	private native void n_onAdShowedFullScreenContent ();


	public void onAdDismissedFullScreenContent ()
	{
		n_onAdDismissedFullScreenContent ();
	}

	private native void n_onAdDismissedFullScreenContent ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
