package crc646380db0424104db8;


public class AdvancedWebView_DownloadListenerAnonymousInnerClass
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.webkit.DownloadListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDownloadStart:(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V:GetOnDownloadStart_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler:Android.Webkit.IDownloadListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("AamarPay.AdvancedWebView+DownloadListenerAnonymousInnerClass, AamarPay", AdvancedWebView_DownloadListenerAnonymousInnerClass.class, __md_methods);
	}


	public AdvancedWebView_DownloadListenerAnonymousInnerClass ()
	{
		super ();
		if (getClass () == AdvancedWebView_DownloadListenerAnonymousInnerClass.class)
			mono.android.TypeManager.Activate ("AamarPay.AdvancedWebView+DownloadListenerAnonymousInnerClass, AamarPay", "", this, new java.lang.Object[] {  });
	}

	public AdvancedWebView_DownloadListenerAnonymousInnerClass (crc646380db0424104db8.AdvancedWebView p0)
	{
		super ();
		if (getClass () == AdvancedWebView_DownloadListenerAnonymousInnerClass.class)
			mono.android.TypeManager.Activate ("AamarPay.AdvancedWebView+DownloadListenerAnonymousInnerClass, AamarPay", "AamarPay.AdvancedWebView, AamarPay", this, new java.lang.Object[] { p0 });
	}


	public void onDownloadStart (java.lang.String p0, java.lang.String p1, java.lang.String p2, java.lang.String p3, long p4)
	{
		n_onDownloadStart (p0, p1, p2, p3, p4);
	}

	private native void n_onDownloadStart (java.lang.String p0, java.lang.String p1, java.lang.String p2, java.lang.String p3, long p4);

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
