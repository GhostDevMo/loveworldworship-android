package crc64655cd00c076b8c4a;


public class BlogAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Blog.Adapters.BlogAdapterViewHolder, DeepSound", BlogAdapterViewHolder.class, __md_methods);
	}


	public BlogAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == BlogAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Blog.Adapters.BlogAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
