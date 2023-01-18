package crc646380db0424104db8;


public class PgwHome_AsyncTrxVerification
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPreExecute:()V:GetOnPreExecuteHandler\n" +
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("AamarPay.PgwHome+AsyncTrxVerification, AamarPay", PgwHome_AsyncTrxVerification.class, __md_methods);
	}


	public PgwHome_AsyncTrxVerification ()
	{
		super ();
		if (getClass () == PgwHome_AsyncTrxVerification.class)
			mono.android.TypeManager.Activate ("AamarPay.PgwHome+AsyncTrxVerification, AamarPay", "", this, new java.lang.Object[] {  });
	}

	public PgwHome_AsyncTrxVerification (crc646380db0424104db8.PgwHome p0)
	{
		super ();
		if (getClass () == PgwHome_AsyncTrxVerification.class)
			mono.android.TypeManager.Activate ("AamarPay.PgwHome+AsyncTrxVerification, AamarPay", "AamarPay.PgwHome, AamarPay", this, new java.lang.Object[] { p0 });
	}


	public void onPreExecute ()
	{
		n_onPreExecute ();
	}

	private native void n_onPreExecute ();


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);

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
