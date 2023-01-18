package crc64e63635b4573bdd3b;


public class PlayerService_MyAudioFocusChangeListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.media.AudioManager.OnAudioFocusChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAudioFocusChange:(I)V:GetOnAudioFocusChange_IHandler:Android.Media.AudioManager/IOnAudioFocusChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Helpers.MediaPlayerController.PlayerService+MyAudioFocusChangeListener, DeepSound", PlayerService_MyAudioFocusChangeListener.class, __md_methods);
	}


	public PlayerService_MyAudioFocusChangeListener ()
	{
		super ();
		if (getClass () == PlayerService_MyAudioFocusChangeListener.class) {
			mono.android.TypeManager.Activate ("DeepSound.Helpers.MediaPlayerController.PlayerService+MyAudioFocusChangeListener, DeepSound", "", this, new java.lang.Object[] {  });
		}
	}


	public void onAudioFocusChange (int p0)
	{
		n_onAudioFocusChange (p0);
	}

	private native void n_onAudioFocusChange (int p0);

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
