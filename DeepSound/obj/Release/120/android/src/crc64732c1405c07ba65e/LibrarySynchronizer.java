package crc64732c1405c07ba65e;


public class LibrarySynchronizer
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Library.Listeners.LibrarySynchronizer, DeepSound", LibrarySynchronizer.class, __md_methods);
	}


	public LibrarySynchronizer ()
	{
		super ();
		if (getClass () == LibrarySynchronizer.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Library.Listeners.LibrarySynchronizer, DeepSound", "", this, new java.lang.Object[] {  });
	}

	public LibrarySynchronizer (android.app.Activity p0)
	{
		super ();
		if (getClass () == LibrarySynchronizer.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Library.Listeners.LibrarySynchronizer, DeepSound", "Android.App.Activity, Mono.Android", this, new java.lang.Object[] { p0 });
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
