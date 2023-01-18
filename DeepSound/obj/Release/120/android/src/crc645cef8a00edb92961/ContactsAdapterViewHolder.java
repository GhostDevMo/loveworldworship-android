package crc645cef8a00edb92961;


public class ContactsAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.MyContacts.Adapters.ContactsAdapterViewHolder, DeepSound", ContactsAdapterViewHolder.class, __md_methods);
	}


	public ContactsAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ContactsAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.MyContacts.Adapters.ContactsAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
