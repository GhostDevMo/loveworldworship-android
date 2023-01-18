package crc64d79e922a6410784b;


public class MyMaterialDialog
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Helpers.Utils.MyMaterialDialog, DeepSound", MyMaterialDialog.class, __md_methods);
	}


	public MyMaterialDialog ()
	{
		super ();
		if (getClass () == MyMaterialDialog.class)
			mono.android.TypeManager.Activate ("DeepSound.Helpers.Utils.MyMaterialDialog, DeepSound", "", this, new java.lang.Object[] {  });
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
