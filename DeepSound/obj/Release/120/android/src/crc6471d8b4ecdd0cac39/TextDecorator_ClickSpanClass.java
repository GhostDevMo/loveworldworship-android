package crc6471d8b4ecdd0cac39;


public class TextDecorator_ClickSpanClass
	extends android.text.style.ClickableSpan
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Helpers.Fonts.TextDecorator+ClickSpanClass, DeepSound", TextDecorator_ClickSpanClass.class, __md_methods);
	}


	public TextDecorator_ClickSpanClass ()
	{
		super ();
		if (getClass () == TextDecorator_ClickSpanClass.class)
			mono.android.TypeManager.Activate ("DeepSound.Helpers.Fonts.TextDecorator+ClickSpanClass, DeepSound", "", this, new java.lang.Object[] {  });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
