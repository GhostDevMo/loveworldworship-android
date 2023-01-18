package crc64e853d4c65778b080;


public class LastSearchAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Search.Adapters.LastSearchAdapterViewHolder, DeepSound", LastSearchAdapterViewHolder.class, __md_methods);
	}


	public LastSearchAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == LastSearchAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Search.Adapters.LastSearchAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
