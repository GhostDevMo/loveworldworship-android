package crc6488293b0456ed0da5;


public class ShowArticleActivity_MyWebViewClient
	extends android.webkit.WebViewClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_shouldOverrideUrlLoading:(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Z:GetShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Handler\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Blog.ShowArticleActivity+MyWebViewClient, DeepSound", ShowArticleActivity_MyWebViewClient.class, __md_methods);
	}


	public ShowArticleActivity_MyWebViewClient ()
	{
		super ();
		if (getClass () == ShowArticleActivity_MyWebViewClient.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Blog.ShowArticleActivity+MyWebViewClient, DeepSound", "", this, new java.lang.Object[] {  });
	}

	public ShowArticleActivity_MyWebViewClient (crc6488293b0456ed0da5.ShowArticleActivity p0)
	{
		super ();
		if (getClass () == ShowArticleActivity_MyWebViewClient.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Blog.ShowArticleActivity+MyWebViewClient, DeepSound", "DeepSound.Activities.Blog.ShowArticleActivity, DeepSound", this, new java.lang.Object[] { p0 });
	}


	public boolean shouldOverrideUrlLoading (android.webkit.WebView p0, android.webkit.WebResourceRequest p1)
	{
		return n_shouldOverrideUrlLoading (p0, p1);
	}

	private native boolean n_shouldOverrideUrlLoading (android.webkit.WebView p0, android.webkit.WebResourceRequest p1);

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
