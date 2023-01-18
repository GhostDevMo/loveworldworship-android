package crc64182ce0c45d16b968;


public class StationsAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Stations.Adapters.StationsAdapterViewHolder, DeepSound", StationsAdapterViewHolder.class, __md_methods);
	}


	public StationsAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == StationsAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Stations.Adapters.StationsAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
