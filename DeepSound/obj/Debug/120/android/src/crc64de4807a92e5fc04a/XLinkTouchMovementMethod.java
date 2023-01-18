package crc64de4807a92e5fc04a;


public class XLinkTouchMovementMethod
	extends android.text.method.LinkMovementMethod
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchEvent:(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Library.Anjo.SuperTextLibrary.XLinkTouchMovementMethod, DeepSound", XLinkTouchMovementMethod.class, __md_methods);
	}


	public XLinkTouchMovementMethod ()
	{
		super ();
		if (getClass () == XLinkTouchMovementMethod.class)
			mono.android.TypeManager.Activate ("DeepSound.Library.Anjo.SuperTextLibrary.XLinkTouchMovementMethod, DeepSound", "", this, new java.lang.Object[] {  });
	}


	public boolean onTouchEvent (android.widget.TextView p0, android.text.Spannable p1, android.view.MotionEvent p2)
	{
		return n_onTouchEvent (p0, p1, p2);
	}

	private native boolean n_onTouchEvent (android.widget.TextView p0, android.text.Spannable p1, android.view.MotionEvent p2);

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
