package crc64e81765df94a28efc;


public class CreateStationsActivity
	extends crc6408e06cf1bfdea485.BaseActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Stations.CreateStationsActivity, DeepSound", CreateStationsActivity.class, __md_methods);
	}


	public CreateStationsActivity ()
	{
		super ();
		if (getClass () == CreateStationsActivity.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Stations.CreateStationsActivity, DeepSound", "", this, new java.lang.Object[] {  });
	}


	public CreateStationsActivity (int p0)
	{
		super (p0);
		if (getClass () == CreateStationsActivity.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Stations.CreateStationsActivity, DeepSound", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();

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
