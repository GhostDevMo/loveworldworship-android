package crc642b11a3a1ccf5afd9;


public class ProductReviewsAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Product.Adapters.ProductReviewsAdapterViewHolder, DeepSound", ProductReviewsAdapterViewHolder.class, __md_methods);
	}


	public ProductReviewsAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ProductReviewsAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Product.Adapters.ProductReviewsAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
