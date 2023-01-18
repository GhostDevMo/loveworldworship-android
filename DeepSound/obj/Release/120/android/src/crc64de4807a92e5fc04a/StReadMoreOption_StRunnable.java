package crc64de4807a92e5fc04a;


public class StReadMoreOption_StRunnable
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.lang.Runnable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_run:()V:GetRunHandler:Java.Lang.IRunnableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Library.Anjo.SuperTextLibrary.StReadMoreOption+StRunnable, DeepSound", StReadMoreOption_StRunnable.class, __md_methods);
	}


	public StReadMoreOption_StRunnable ()
	{
		super ();
		if (getClass () == StReadMoreOption_StRunnable.class)
			mono.android.TypeManager.Activate ("DeepSound.Library.Anjo.SuperTextLibrary.StReadMoreOption+StRunnable, DeepSound", "", this, new java.lang.Object[] {  });
	}


	public void run ()
	{
		n_run ();
	}

	private native void n_run ();

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
