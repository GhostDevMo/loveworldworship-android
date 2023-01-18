package crc64c16a1c429c58356f;


public class HomeActivity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		androidx.slidingpanelayout.widget.SlidingPaneLayout.PanelSlideListener,
		com.sothree.slidinguppanel.SlidingUpPanelLayout.PanelSlideListener,
		com.google.android.material.appbar.AppBarLayout.OnOffsetChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onTrimMemory:(I)V:GetOnTrimMemory_IHandler\n" +
			"n_onLowMemory:()V:GetOnLowMemoryHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_onConfigurationChanged:(Landroid/content/res/Configuration;)V:GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler\n" +
			"n_onOptionsItemSelected:(Landroid/view/MenuItem;)Z:GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler\n" +
			"n_onBackPressed:()V:GetOnBackPressedHandler\n" +
			"n_onActivityResult:(IILandroid/content/Intent;)V:GetOnActivityResult_IILandroid_content_Intent_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"n_onPanelClosed:(Landroid/view/View;)V:GetOnPanelClosed_Landroid_view_View_Handler:AndroidX.SlidingPaneLayout.Widget.SlidingPaneLayout/IPanelSlideListenerInvoker, Xamarin.AndroidX.SlidingPaneLayout\n" +
			"n_onPanelOpened:(Landroid/view/View;)V:GetOnPanelOpened_Landroid_view_View_Handler:AndroidX.SlidingPaneLayout.Widget.SlidingPaneLayout/IPanelSlideListenerInvoker, Xamarin.AndroidX.SlidingPaneLayout\n" +
			"n_onPanelSlide:(Landroid/view/View;F)V:GetOnPanelSlide_Landroid_view_View_FHandler:AndroidX.SlidingPaneLayout.Widget.SlidingPaneLayout/IPanelSlideListenerInvoker, Xamarin.AndroidX.SlidingPaneLayout\n" +
			"n_onPanelStateChanged:(Landroid/view/View;Lcom/sothree/slidinguppanel/SlidingUpPanelLayout$PanelState;Lcom/sothree/slidinguppanel/SlidingUpPanelLayout$PanelState;)V:GetOnPanelStateChanged_Landroid_view_View_Lcom_sothree_slidinguppanel_SlidingUpPanelLayout_PanelState_Lcom_sothree_slidinguppanel_SlidingUpPanelLayout_PanelState_Handler:Com.Sothree.Slidinguppanel.SlidingUpPanelLayout/IPanelSlideListenerInvoker, Xamarin.Bindings.AndroidXSlidingUpPanel\n" +
			"n_onOffsetChanged:(Lcom/google/android/material/appbar/AppBarLayout;I)V:GetOnOffsetChanged_Lcom_google_android_material_appbar_AppBarLayout_IHandler:Google.Android.Material.AppBar.AppBarLayout/IOnOffsetChangedListenerInvoker, Xamarin.Google.Android.Material\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Tabbes.HomeActivity, DeepSound", HomeActivity.class, __md_methods);
	}


	public HomeActivity ()
	{
		super ();
		if (getClass () == HomeActivity.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Tabbes.HomeActivity, DeepSound", "", this, new java.lang.Object[] {  });
	}


	public HomeActivity (int p0)
	{
		super (p0);
		if (getClass () == HomeActivity.class)
			mono.android.TypeManager.Activate ("DeepSound.Activities.Tabbes.HomeActivity, DeepSound", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
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


	public void onTrimMemory (int p0)
	{
		n_onTrimMemory (p0);
	}

	private native void n_onTrimMemory (int p0);


	public void onLowMemory ()
	{
		n_onLowMemory ();
	}

	private native void n_onLowMemory ();


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();


	public void onConfigurationChanged (android.content.res.Configuration p0)
	{
		n_onConfigurationChanged (p0);
	}

	private native void n_onConfigurationChanged (android.content.res.Configuration p0);


	public boolean onOptionsItemSelected (android.view.MenuItem p0)
	{
		return n_onOptionsItemSelected (p0);
	}

	private native boolean n_onOptionsItemSelected (android.view.MenuItem p0);


	public void onBackPressed ()
	{
		n_onBackPressed ();
	}

	private native void n_onBackPressed ();


	public void onActivityResult (int p0, int p1, android.content.Intent p2)
	{
		n_onActivityResult (p0, p1, p2);
	}

	private native void n_onActivityResult (int p0, int p1, android.content.Intent p2);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);


	public void onPanelClosed (android.view.View p0)
	{
		n_onPanelClosed (p0);
	}

	private native void n_onPanelClosed (android.view.View p0);


	public void onPanelOpened (android.view.View p0)
	{
		n_onPanelOpened (p0);
	}

	private native void n_onPanelOpened (android.view.View p0);


	public void onPanelSlide (android.view.View p0, float p1)
	{
		n_onPanelSlide (p0, p1);
	}

	private native void n_onPanelSlide (android.view.View p0, float p1);


	public void onPanelStateChanged (android.view.View p0, com.sothree.slidinguppanel.SlidingUpPanelLayout.PanelState p1, com.sothree.slidinguppanel.SlidingUpPanelLayout.PanelState p2)
	{
		n_onPanelStateChanged (p0, p1, p2);
	}

	private native void n_onPanelStateChanged (android.view.View p0, com.sothree.slidinguppanel.SlidingUpPanelLayout.PanelState p1, com.sothree.slidinguppanel.SlidingUpPanelLayout.PanelState p2);


	public void onOffsetChanged (com.google.android.material.appbar.AppBarLayout p0, int p1)
	{
		n_onOffsetChanged (p0, p1);
	}

	private native void n_onOffsetChanged (com.google.android.material.appbar.AppBarLayout p0, int p1);

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
