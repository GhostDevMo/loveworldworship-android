package crc6471fceb97d8fbc55a;


public class IyziPayView
	extends android.webkit.WebView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("IyziPay.IyziPayView, IyziPay", IyziPayView.class, __md_methods);
	}


	public IyziPayView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == IyziPayView.class) {
			mono.android.TypeManager.Activate ("IyziPay.IyziPayView, IyziPay", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public IyziPayView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == IyziPayView.class) {
			mono.android.TypeManager.Activate ("IyziPay.IyziPayView, IyziPay", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public IyziPayView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == IyziPayView.class) {
			mono.android.TypeManager.Activate ("IyziPay.IyziPayView, IyziPay", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public IyziPayView (android.content.Context p0, android.util.AttributeSet p1, int p2, boolean p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == IyziPayView.class) {
			mono.android.TypeManager.Activate ("IyziPay.IyziPayView, IyziPay", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public IyziPayView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == IyziPayView.class) {
			mono.android.TypeManager.Activate ("IyziPay.IyziPayView, IyziPay", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}

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
