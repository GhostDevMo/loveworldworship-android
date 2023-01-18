package crc64ee01847ad9d83b17;


public class ArtistsAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Artists.Adapters.ArtistsAdapterViewHolder, DeepSound", ArtistsAdapterViewHolder.class, __md_methods);
	}


	public ArtistsAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ArtistsAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Artists.Adapters.ArtistsAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
