package crc64053dad182fb805f8;


public class PlaylistAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Playlist.Adapters.PlaylistAdapterViewHolder, DeepSound", PlaylistAdapterViewHolder.class, __md_methods);
	}


	public PlaylistAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == PlaylistAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Playlist.Adapters.PlaylistAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
