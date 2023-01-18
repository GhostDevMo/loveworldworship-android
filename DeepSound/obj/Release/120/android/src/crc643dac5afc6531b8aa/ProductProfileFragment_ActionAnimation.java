package crc643dac5afc6531b8aa;


public class ProductProfileFragment_ActionAnimation
	extends android.view.animation.Animation
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_applyTransformation:(FLandroid/view/animation/Transformation;)V:GetApplyTransformation_FLandroid_view_animation_Transformation_Handler\n" +
			"n_willChangeBounds:()Z:GetWillChangeBoundsHandler\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Product.ProductProfileFragment+ActionAnimation, DeepSound", ProductProfileFragment_ActionAnimation.class, __md_methods);
	}


	public ProductProfileFragment_ActionAnimation ()
	{
		super ();
		if (getClass () == ProductProfileFragment_ActionAnimation.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Product.ProductProfileFragment+ActionAnimation, DeepSound", "", this, new java.lang.Object[] {  });
	}


	public ProductProfileFragment_ActionAnimation (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ProductProfileFragment_ActionAnimation.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Product.ProductProfileFragment+ActionAnimation, DeepSound", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}

	public ProductProfileFragment_ActionAnimation (android.view.View p0, int p1, java.lang.String p2)
	{
		super ();
		if (getClass () == ProductProfileFragment_ActionAnimation.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Product.ProductProfileFragment+ActionAnimation, DeepSound", "Android.Views.View, Mono.Android:System.Int32, mscorlib:System.String, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void applyTransformation (float p0, android.view.animation.Transformation p1)
	{
		n_applyTransformation (p0, p1);
	}

	private native void n_applyTransformation (float p0, android.view.animation.Transformation p1);


	public boolean willChangeBounds ()
	{
		return n_willChangeBounds ();
	}

	private native boolean n_willChangeBounds ();

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
