package crc64abf467cb85f0c958;


public class ProfileFragment_MyOnPageChangeCallback
	extends androidx.viewpager2.widget.ViewPager2.OnPageChangeCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPageSelected:(I)V:GetOnPageSelected_IHandler\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Tabbes.Fragments.ProfileFragment+MyOnPageChangeCallback, DeepSound", ProfileFragment_MyOnPageChangeCallback.class, __md_methods);
	}


	public ProfileFragment_MyOnPageChangeCallback ()
	{
		super ();
		if (getClass () == ProfileFragment_MyOnPageChangeCallback.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Tabbes.Fragments.ProfileFragment+MyOnPageChangeCallback, DeepSound", "", this, new java.lang.Object[] {  });
		}
	}

	public ProfileFragment_MyOnPageChangeCallback (crc64abf467cb85f0c958.ProfileFragment p0)
	{
		super ();
		if (getClass () == ProfileFragment_MyOnPageChangeCallback.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Tabbes.Fragments.ProfileFragment+MyOnPageChangeCallback, DeepSound", "DeepSound.Activities.Tabbes.Fragments.ProfileFragment, DeepSound", this, new java.lang.Object[] { p0 });
		}
	}


	public void onPageSelected (int p0)
	{
		n_onPageSelected (p0);
	}

	private native void n_onPageSelected (int p0);

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
