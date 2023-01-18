package crc6425872139d5a5cb49;


public class PopupDialogController
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Helpers.Controller.PopupDialogController, DeepSound", PopupDialogController.class, __md_methods);
	}


	public PopupDialogController ()
	{
		super ();
		if (getClass () == PopupDialogController.class) {
			mono.android.TypeManager.Activate ("DeepSound.Helpers.Controller.PopupDialogController, DeepSound", "", this, new java.lang.Object[] {  });
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
