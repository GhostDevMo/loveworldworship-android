package crc646380db0424104db8;


public class AdvancedWebView_WebViewClientAnonymousInnerClass
	extends android.webkit.WebViewClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPageStarted:(Landroid/webkit/WebView;Ljava/lang/String;Landroid/graphics/Bitmap;)V:GetOnPageStarted_Landroid_webkit_WebView_Ljava_lang_String_Landroid_graphics_Bitmap_Handler\n" +
			"n_onPageFinished:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnPageFinished_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"n_onReceivedError:(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;Landroid/webkit/WebResourceError;)V:GetOnReceivedError_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Landroid_webkit_WebResourceError_Handler\n" +
			"n_shouldOverrideUrlLoading:(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Z:GetShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Handler\n" +
			"n_onLoadResource:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnLoadResource_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"n_shouldInterceptRequest:(Landroid/webkit/WebView;Ljava/lang/String;)Landroid/webkit/WebResourceResponse;:GetShouldInterceptRequest_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"n_shouldInterceptRequest:(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Landroid/webkit/WebResourceResponse;:GetShouldInterceptRequest_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Handler\n" +
			"n_onFormResubmission:(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V:GetOnFormResubmission_Landroid_webkit_WebView_Landroid_os_Message_Landroid_os_Message_Handler\n" +
			"n_doUpdateVisitedHistory:(Landroid/webkit/WebView;Ljava/lang/String;Z)V:GetDoUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_ZHandler\n" +
			"n_onReceivedSslError:(Landroid/webkit/WebView;Landroid/webkit/SslErrorHandler;Landroid/net/http/SslError;)V:GetOnReceivedSslError_Landroid_webkit_WebView_Landroid_webkit_SslErrorHandler_Landroid_net_http_SslError_Handler\n" +
			"n_onReceivedClientCertRequest:(Landroid/webkit/WebView;Landroid/webkit/ClientCertRequest;)V:GetOnReceivedClientCertRequest_Landroid_webkit_WebView_Landroid_webkit_ClientCertRequest_Handler\n" +
			"n_onReceivedHttpAuthRequest:(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)V:GetOnReceivedHttpAuthRequest_Landroid_webkit_WebView_Landroid_webkit_HttpAuthHandler_Ljava_lang_String_Ljava_lang_String_Handler\n" +
			"n_shouldOverrideKeyEvent:(Landroid/webkit/WebView;Landroid/view/KeyEvent;)Z:GetShouldOverrideKeyEvent_Landroid_webkit_WebView_Landroid_view_KeyEvent_Handler\n" +
			"n_onUnhandledKeyEvent:(Landroid/webkit/WebView;Landroid/view/KeyEvent;)V:GetOnUnhandledKeyEvent_Landroid_webkit_WebView_Landroid_view_KeyEvent_Handler\n" +
			"n_onUnhandledInputEvent:(Landroid/webkit/WebView;Landroid/view/InputEvent;)V:GetOnUnhandledInputEvent_Landroid_webkit_WebView_Landroid_view_InputEvent_Handler\n" +
			"n_onScaleChanged:(Landroid/webkit/WebView;FF)V:GetOnScaleChanged_Landroid_webkit_WebView_FFHandler\n" +
			"n_onReceivedLoginRequest:(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V:GetOnReceivedLoginRequest_Landroid_webkit_WebView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("AamarPay.AdvancedWebView+WebViewClientAnonymousInnerClass, AamarPay", AdvancedWebView_WebViewClientAnonymousInnerClass.class, __md_methods);
	}


	public AdvancedWebView_WebViewClientAnonymousInnerClass ()
	{
		super ();
		if (getClass () == AdvancedWebView_WebViewClientAnonymousInnerClass.class) {
			mono.android.TypeManager.Activate ("AamarPay.AdvancedWebView+WebViewClientAnonymousInnerClass, AamarPay", "", this, new java.lang.Object[] {  });
		}
	}

	public AdvancedWebView_WebViewClientAnonymousInnerClass (crc646380db0424104db8.AdvancedWebView p0)
	{
		super ();
		if (getClass () == AdvancedWebView_WebViewClientAnonymousInnerClass.class) {
			mono.android.TypeManager.Activate ("AamarPay.AdvancedWebView+WebViewClientAnonymousInnerClass, AamarPay", "AamarPay.AdvancedWebView, AamarPay", this, new java.lang.Object[] { p0 });
		}
	}


	public void onPageStarted (android.webkit.WebView p0, java.lang.String p1, android.graphics.Bitmap p2)
	{
		n_onPageStarted (p0, p1, p2);
	}

	private native void n_onPageStarted (android.webkit.WebView p0, java.lang.String p1, android.graphics.Bitmap p2);


	public void onPageFinished (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onPageFinished (p0, p1);
	}

	private native void n_onPageFinished (android.webkit.WebView p0, java.lang.String p1);


	public void onReceivedError (android.webkit.WebView p0, android.webkit.WebResourceRequest p1, android.webkit.WebResourceError p2)
	{
		n_onReceivedError (p0, p1, p2);
	}

	private native void n_onReceivedError (android.webkit.WebView p0, android.webkit.WebResourceRequest p1, android.webkit.WebResourceError p2);


	public boolean shouldOverrideUrlLoading (android.webkit.WebView p0, android.webkit.WebResourceRequest p1)
	{
		return n_shouldOverrideUrlLoading (p0, p1);
	}

	private native boolean n_shouldOverrideUrlLoading (android.webkit.WebView p0, android.webkit.WebResourceRequest p1);


	public void onLoadResource (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onLoadResource (p0, p1);
	}

	private native void n_onLoadResource (android.webkit.WebView p0, java.lang.String p1);


	public android.webkit.WebResourceResponse shouldInterceptRequest (android.webkit.WebView p0, java.lang.String p1)
	{
		return n_shouldInterceptRequest (p0, p1);
	}

	private native android.webkit.WebResourceResponse n_shouldInterceptRequest (android.webkit.WebView p0, java.lang.String p1);


	public android.webkit.WebResourceResponse shouldInterceptRequest (android.webkit.WebView p0, android.webkit.WebResourceRequest p1)
	{
		return n_shouldInterceptRequest (p0, p1);
	}

	private native android.webkit.WebResourceResponse n_shouldInterceptRequest (android.webkit.WebView p0, android.webkit.WebResourceRequest p1);


	public void onFormResubmission (android.webkit.WebView p0, android.os.Message p1, android.os.Message p2)
	{
		n_onFormResubmission (p0, p1, p2);
	}

	private native void n_onFormResubmission (android.webkit.WebView p0, android.os.Message p1, android.os.Message p2);


	public void doUpdateVisitedHistory (android.webkit.WebView p0, java.lang.String p1, boolean p2)
	{
		n_doUpdateVisitedHistory (p0, p1, p2);
	}

	private native void n_doUpdateVisitedHistory (android.webkit.WebView p0, java.lang.String p1, boolean p2);


	public void onReceivedSslError (android.webkit.WebView p0, android.webkit.SslErrorHandler p1, android.net.http.SslError p2)
	{
		n_onReceivedSslError (p0, p1, p2);
	}

	private native void n_onReceivedSslError (android.webkit.WebView p0, android.webkit.SslErrorHandler p1, android.net.http.SslError p2);


	public void onReceivedClientCertRequest (android.webkit.WebView p0, android.webkit.ClientCertRequest p1)
	{
		n_onReceivedClientCertRequest (p0, p1);
	}

	private native void n_onReceivedClientCertRequest (android.webkit.WebView p0, android.webkit.ClientCertRequest p1);


	public void onReceivedHttpAuthRequest (android.webkit.WebView p0, android.webkit.HttpAuthHandler p1, java.lang.String p2, java.lang.String p3)
	{
		n_onReceivedHttpAuthRequest (p0, p1, p2, p3);
	}

	private native void n_onReceivedHttpAuthRequest (android.webkit.WebView p0, android.webkit.HttpAuthHandler p1, java.lang.String p2, java.lang.String p3);


	public boolean shouldOverrideKeyEvent (android.webkit.WebView p0, android.view.KeyEvent p1)
	{
		return n_shouldOverrideKeyEvent (p0, p1);
	}

	private native boolean n_shouldOverrideKeyEvent (android.webkit.WebView p0, android.view.KeyEvent p1);


	public void onUnhandledKeyEvent (android.webkit.WebView p0, android.view.KeyEvent p1)
	{
		n_onUnhandledKeyEvent (p0, p1);
	}

	private native void n_onUnhandledKeyEvent (android.webkit.WebView p0, android.view.KeyEvent p1);


	public void onUnhandledInputEvent (android.webkit.WebView p0, android.view.InputEvent p1)
	{
		n_onUnhandledInputEvent (p0, p1);
	}

	private native void n_onUnhandledInputEvent (android.webkit.WebView p0, android.view.InputEvent p1);


	public void onScaleChanged (android.webkit.WebView p0, float p1, float p2)
	{
		n_onScaleChanged (p0, p1, p2);
	}

	private native void n_onScaleChanged (android.webkit.WebView p0, float p1, float p2);


	public void onReceivedLoginRequest (android.webkit.WebView p0, java.lang.String p1, java.lang.String p2, java.lang.String p3)
	{
		n_onReceivedLoginRequest (p0, p1, p2, p3);
	}

	private native void n_onReceivedLoginRequest (android.webkit.WebView p0, java.lang.String p1, java.lang.String p2, java.lang.String p3);

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
