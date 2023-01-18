package crc64c5359ab32e5b9429;


public class SecurionPayBridge
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_SendStateError:(Ljava/lang/String;)V:__export__\n" +
			"n_SendStateSuccess:(Ljava/lang/String;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("SecurionPay.SecurionPayBridge, SecurionPay", SecurionPayBridge.class, __md_methods);
	}


	public SecurionPayBridge ()
	{
		super ();
		if (getClass () == SecurionPayBridge.class) {
			mono.android.TypeManager.Activate ("SecurionPay.SecurionPayBridge, SecurionPay", "", this, new java.lang.Object[] {  });
		}
	}

	@android.webkit.JavascriptInterface

	public void SendStateError (java.lang.String p0)
	{
		n_SendStateError (p0);
	}

	private native void n_SendStateError (java.lang.String p0);

	@android.webkit.JavascriptInterface

	public void SendStateSuccess (java.lang.String p0)
	{
		n_SendStateSuccess (p0);
	}

	private native void n_SendStateSuccess (java.lang.String p0);

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
