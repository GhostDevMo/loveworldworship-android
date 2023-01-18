package crc64222ec12c31b111b5;


public class ItemOptionAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Adapters.ItemOptionAdapterViewHolder, DeepSound", ItemOptionAdapterViewHolder.class, __md_methods);
	}


	public ItemOptionAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ItemOptionAdapterViewHolder.class) {
			mono.android.TypeManager.Activate ("DeepSound.Adapters.ItemOptionAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
