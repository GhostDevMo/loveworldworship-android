package crc647a31f8be71cd61dc;


public class CarouselEffectTransformer2
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.viewpager.widget.ViewPager.PageTransformer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_transformPage:(Landroid/view/View;F)V:GetTransformPage_Landroid_view_View_FHandler:AndroidX.ViewPager.Widget.ViewPager/IPageTransformerInvoker, Xamarin.AndroidX.ViewPager\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Helpers.CacheLoaders.CarouselEffectTransformer2, DeepSound", CarouselEffectTransformer2.class, __md_methods);
	}


	public CarouselEffectTransformer2 ()
	{
		super ();
		if (getClass () == CarouselEffectTransformer2.class) {
			mono.android.TypeManager.Activate ("DeepSound.Helpers.CacheLoaders.CarouselEffectTransformer2, DeepSound", "", this, new java.lang.Object[] {  });
		}
	}

	public CarouselEffectTransformer2 (android.content.Context p0)
	{
		super ();
		if (getClass () == CarouselEffectTransformer2.class) {
			mono.android.TypeManager.Activate ("DeepSound.Helpers.CacheLoaders.CarouselEffectTransformer2, DeepSound", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public void transformPage (android.view.View p0, float p1)
	{
		n_transformPage (p0, p1);
	}

	private native void n_transformPage (android.view.View p0, float p1);

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
