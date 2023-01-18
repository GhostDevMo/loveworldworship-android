package crc64e9d95be4c9ccef87;


public class ActivitiesAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Tabbes.Adapters.ActivitiesAdapterViewHolder, DeepSound", ActivitiesAdapterViewHolder.class, __md_methods);
	}


	public ActivitiesAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ActivitiesAdapterViewHolder.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Tabbes.Adapters.ActivitiesAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
