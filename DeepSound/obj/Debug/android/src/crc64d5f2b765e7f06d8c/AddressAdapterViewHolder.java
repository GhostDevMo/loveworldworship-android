package crc64d5f2b765e7f06d8c;


public class AddressAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Address.Adapters.AddressAdapterViewHolder, DeepSound", AddressAdapterViewHolder.class, __md_methods);
	}


	public AddressAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == AddressAdapterViewHolder.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Address.Adapters.AddressAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
