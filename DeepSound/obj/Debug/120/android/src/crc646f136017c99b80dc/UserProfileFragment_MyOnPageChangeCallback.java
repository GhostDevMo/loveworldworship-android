package crc646f136017c99b80dc;


public class UserProfileFragment_MyOnPageChangeCallback
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
		mono.android.Runtime.register ("DeepSound.Activities.UserProfile.UserProfileFragment+MyOnPageChangeCallback, DeepSound", UserProfileFragment_MyOnPageChangeCallback.class, __md_methods);
	}


	public UserProfileFragment_MyOnPageChangeCallback ()
	{
		super ();
		if (getClass () == UserProfileFragment_MyOnPageChangeCallback.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.UserProfile.UserProfileFragment+MyOnPageChangeCallback, DeepSound", "", this, new java.lang.Object[] {  });
	}

	public UserProfileFragment_MyOnPageChangeCallback (crc646f136017c99b80dc.UserProfileFragment p0)
	{
		super ();
		if (getClass () == UserProfileFragment_MyOnPageChangeCallback.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.UserProfile.UserProfileFragment+MyOnPageChangeCallback, DeepSound", "DeepSound.Activities.UserProfile.UserProfileFragment, DeepSound", this, new java.lang.Object[] { p0 });
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
