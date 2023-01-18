package crc64a44c221d3463e07d;


public class SplashScreenActivity
	extends crc6408e06cf1bfdea485.BaseActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Activities.SplashScreenActivity, DeepSound", SplashScreenActivity.class, __md_methods);
	}


	public SplashScreenActivity ()
	{
		super ();
		if (getClass () == SplashScreenActivity.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.SplashScreenActivity, DeepSound", "", this, new java.lang.Object[] {  });
	}


	public SplashScreenActivity (int p0)
	{
		super (p0);
		if (getClass () == SplashScreenActivity.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.SplashScreenActivity, DeepSound", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
