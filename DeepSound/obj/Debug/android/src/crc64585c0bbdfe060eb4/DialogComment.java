package crc64585c0bbdfe060eb4;


public class DialogComment
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Comments.DialogComment, DeepSound", DialogComment.class, __md_methods);
	}


	public DialogComment ()
	{
		super ();
		if (getClass () == DialogComment.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Comments.DialogComment, DeepSound", "", this, new java.lang.Object[] {  });
		}
	}

	public DialogComment (android.app.Activity p0)
	{
		super ();
		if (getClass () == DialogComment.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Comments.DialogComment, DeepSound", "Android.App.Activity, Mono.Android", this, new java.lang.Object[] { p0 });
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
