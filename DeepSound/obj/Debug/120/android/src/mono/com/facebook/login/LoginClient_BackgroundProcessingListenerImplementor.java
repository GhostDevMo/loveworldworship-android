package mono.com.facebook.login;


public class LoginClient_BackgroundProcessingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.login.LoginClient.BackgroundProcessingListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBackgroundProcessingStarted:()V:GetOnBackgroundProcessingStartedHandler:Xamarin.Facebook.Login.LoginClient/IBackgroundProcessingListenerInvoker, FacebookCommon\n" +
			"n_onBackgroundProcessingStopped:()V:GetOnBackgroundProcessingStoppedHandler:Xamarin.Facebook.Login.LoginClient/IBackgroundProcessingListenerInvoker, FacebookCommon\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.Login.LoginClient+IBackgroundProcessingListenerImplementor, FacebookCommon", LoginClient_BackgroundProcessingListenerImplementor.class, __md_methods);
	}


	public LoginClient_BackgroundProcessingListenerImplementor ()
	{
		super ();
		if (getClass () == LoginClient_BackgroundProcessingListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.Login.LoginClient+IBackgroundProcessingListenerImplementor, FacebookCommon", "", this, new java.lang.Object[] {  });
	}


	public void onBackgroundProcessingStarted ()
	{
		n_onBackgroundProcessingStarted ();
	}

	private native void n_onBackgroundProcessingStarted ();


	public void onBackgroundProcessingStopped ()
	{
		n_onBackgroundProcessingStopped ();
	}

	private native void n_onBackgroundProcessingStopped ();

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
