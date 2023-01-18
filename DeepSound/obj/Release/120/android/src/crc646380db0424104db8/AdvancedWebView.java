package crc646380db0424104db8;


public class AdvancedWebView
	extends android.webkit.WebView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setWebViewClient:(Landroid/webkit/WebViewClient;)V:GetSetWebViewClient_Landroid_webkit_WebViewClient_Handler\n" +
			"n_setWebChromeClient:(Landroid/webkit/WebChromeClient;)V:GetSetWebChromeClient_Landroid_webkit_WebChromeClient_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_destroy:()V:GetDestroyHandler\n" +
			"n_loadUrl:(Ljava/lang/String;Ljava/util/Map;)V:GetLoadUrl_Ljava_lang_String_Ljava_util_Map_Handler\n" +
			"n_loadUrl:(Ljava/lang/String;)V:GetLoadUrl_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("AamarPay.AdvancedWebView, AamarPay", AdvancedWebView.class, __md_methods);
	}


	public AdvancedWebView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AdvancedWebView.class)
			mono.android.TypeManager.Activate ("AamarPay.AdvancedWebView, AamarPay", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public AdvancedWebView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AdvancedWebView.class)
			mono.android.TypeManager.Activate ("AamarPay.AdvancedWebView, AamarPay", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public AdvancedWebView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AdvancedWebView.class)
			mono.android.TypeManager.Activate ("AamarPay.AdvancedWebView, AamarPay", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public AdvancedWebView (android.content.Context p0, android.util.AttributeSet p1, int p2, boolean p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AdvancedWebView.class)
			mono.android.TypeManager.Activate ("AamarPay.AdvancedWebView, AamarPay", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public AdvancedWebView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AdvancedWebView.class)
			mono.android.TypeManager.Activate ("AamarPay.AdvancedWebView, AamarPay", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void setWebViewClient (android.webkit.WebViewClient p0)
	{
		n_setWebViewClient (p0);
	}

	private native void n_setWebViewClient (android.webkit.WebViewClient p0);


	public void setWebChromeClient (android.webkit.WebChromeClient p0)
	{
		n_setWebChromeClient (p0);
	}

	private native void n_setWebChromeClient (android.webkit.WebChromeClient p0);


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();


	public void destroy ()
	{
		n_destroy ();
	}

	private native void n_destroy ();


	public void loadUrl (java.lang.String p0, java.util.Map p1)
	{
		n_loadUrl (p0, p1);
	}

	private native void n_loadUrl (java.lang.String p0, java.util.Map p1);


	public void loadUrl (java.lang.String p0)
	{
		n_loadUrl (p0);
	}

	private native void n_loadUrl (java.lang.String p0);

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
