package crc6471fceb97d8fbc55a;


public class IyziPayView_MyWebChromeClient
	extends android.webkit.WebChromeClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onReceivedTitle:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnReceivedTitle_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("IyziPay.IyziPayView+MyWebChromeClient, IyziPay", IyziPayView_MyWebChromeClient.class, __md_methods);
	}


	public IyziPayView_MyWebChromeClient ()
	{
		super ();
		if (getClass () == IyziPayView_MyWebChromeClient.class) {
			mono.android.TypeManager.Activate ("IyziPay.IyziPayView+MyWebChromeClient, IyziPay", "", this, new java.lang.Object[] {  });
		}
	}


	public void onReceivedTitle (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onReceivedTitle (p0, p1);
	}

	private native void n_onReceivedTitle (android.webkit.WebView p0, java.lang.String p1);

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
