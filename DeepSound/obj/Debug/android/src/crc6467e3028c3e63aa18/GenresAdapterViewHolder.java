package crc6467e3028c3e63aa18;


public class GenresAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Genres.Adapters.GenresAdapterViewHolder, DeepSound", GenresAdapterViewHolder.class, __md_methods);
	}


	public GenresAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == GenresAdapterViewHolder.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Genres.Adapters.GenresAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
