package crc64183fc81362e946c5;


public class MyPurchasesAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Library.Adapters.MyPurchasesAdapterViewHolder, DeepSound", MyPurchasesAdapterViewHolder.class, __md_methods);
	}


	public MyPurchasesAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == MyPurchasesAdapterViewHolder.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Library.Adapters.MyPurchasesAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
