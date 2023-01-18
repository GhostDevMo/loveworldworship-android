package crc640a49d6c6c1f86368;


public class PaymentHistoryAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.SettingsUser.Adapters.PaymentHistoryAdapterViewHolder, DeepSound", PaymentHistoryAdapterViewHolder.class, __md_methods);
	}


	public PaymentHistoryAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == PaymentHistoryAdapterViewHolder.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.SettingsUser.Adapters.PaymentHistoryAdapterViewHolder, DeepSound", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
