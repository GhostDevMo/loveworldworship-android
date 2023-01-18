package crc64988121f382a25c92;


public class LoginActivity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		com.facebook.FacebookCallback,
		com.facebook.GraphRequest.GraphJSONObjectCallback,
		com.google.android.gms.tasks.OnCompleteListener,
		com.google.android.gms.tasks.OnFailureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onStart:()V:GetOnStartHandler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onTrimMemory:(I)V:GetOnTrimMemory_IHandler\n" +
			"n_onLowMemory:()V:GetOnLowMemoryHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_onActivityResult:(IILandroid/content/Intent;)V:GetOnActivityResult_IILandroid_content_Intent_Handler\n" +
			"n_onCancel:()V:GetOnCancelHandler:Xamarin.Facebook.IFacebookCallbackInvoker, FacebookCommon\n" +
			"n_onError:(Lcom/facebook/FacebookException;)V:GetOnError_Lcom_facebook_FacebookException_Handler:Xamarin.Facebook.IFacebookCallbackInvoker, FacebookCommon\n" +
			"n_onSuccess:(Ljava/lang/Object;)V:GetOnSuccess_Ljava_lang_Object_Handler:Xamarin.Facebook.IFacebookCallbackInvoker, FacebookCommon\n" +
			"n_onCompleted:(Lorg/json/JSONObject;Lcom/facebook/GraphResponse;)V:GetOnCompleted_Lorg_json_JSONObject_Lcom_facebook_GraphResponse_Handler:Xamarin.Facebook.GraphRequest/IGraphJSONObjectCallbackInvoker, FacebookCore\n" +
			"n_onComplete:(Lcom/google/android/gms/tasks/Task;)V:GetOnComplete_Lcom_google_android_gms_tasks_Task_Handler:Android.Gms.Tasks.IOnCompleteListenerInvoker, Xamarin.GooglePlayServices.Tasks\n" +
			"n_onFailure:(Ljava/lang/Exception;)V:GetOnFailure_Ljava_lang_Exception_Handler:Android.Gms.Tasks.IOnFailureListenerInvoker, Xamarin.GooglePlayServices.Tasks\n" +
			"";
		mono.android.Runtime.register ("DeepSound.Activities.Default.LoginActivity, DeepSound", LoginActivity.class, __md_methods);
	}


	public LoginActivity ()
	{
		super ();
		if (getClass () == LoginActivity.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Default.LoginActivity, DeepSound", "", this, new java.lang.Object[] {  });
		}
	}


	public LoginActivity (int p0)
	{
		super (p0);
		if (getClass () == LoginActivity.class) {
			mono.android.TypeManager.Activate ("DeepSound.Activities.Default.LoginActivity, DeepSound", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();


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


	public void onActivityResult (int p0, int p1, android.content.Intent p2)
	{
		n_onActivityResult (p0, p1, p2);
	}

	private native void n_onActivityResult (int p0, int p1, android.content.Intent p2);


	public void onCancel ()
	{
		n_onCancel ();
	}

	private native void n_onCancel ();


	public void onError (com.facebook.FacebookException p0)
	{
		n_onError (p0);
	}

	private native void n_onError (com.facebook.FacebookException p0);


	public void onSuccess (java.lang.Object p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (java.lang.Object p0);


	public void onCompleted (org.json.JSONObject p0, com.facebook.GraphResponse p1)
	{
		n_onCompleted (p0, p1);
	}

	private native void n_onCompleted (org.json.JSONObject p0, com.facebook.GraphResponse p1);


	public void onComplete (com.google.android.gms.tasks.Task p0)
	{
		n_onComplete (p0);
	}

	private native void n_onComplete (com.google.android.gms.tasks.Task p0);


	public void onFailure (java.lang.Exception p0)
	{
		n_onFailure (p0);
	}

	private native void n_onFailure (java.lang.Exception p0);

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
