package mono.com.facebook.login;


public class LoginClient_OnCompletedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.login.LoginClient.OnCompletedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCompleted:(Lcom/facebook/login/LoginClient$Result;)V:GetOnCompleted_Lcom_facebook_login_LoginClient_Result_Handler:Xamarin.Facebook.Login.LoginClient/IOnCompletedListenerInvoker, FacebookCommon\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.Login.LoginClient+IOnCompletedListenerImplementor, FacebookCommon", LoginClient_OnCompletedListenerImplementor.class, __md_methods);
	}


	public LoginClient_OnCompletedListenerImplementor ()
	{
		super ();
		if (getClass () == LoginClient_OnCompletedListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Xamarin.Facebook.Login.LoginClient+IOnCompletedListenerImplementor, FacebookCommon", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCompleted (com.facebook.login.LoginClient.Result p0)
	{
		n_onCompleted (p0);
	}

	private native void n_onCompleted (com.facebook.login.LoginClient.Result p0);

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
