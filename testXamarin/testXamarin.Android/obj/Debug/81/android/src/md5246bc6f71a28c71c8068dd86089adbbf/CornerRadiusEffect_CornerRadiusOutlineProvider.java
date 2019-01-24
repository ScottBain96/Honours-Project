package md5246bc6f71a28c71c8068dd86089adbbf;


public class CornerRadiusEffect_CornerRadiusOutlineProvider
	extends android.view.ViewOutlineProvider
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getOutline:(Landroid/view/View;Landroid/graphics/Outline;)V:GetGetOutline_Landroid_view_View_Landroid_graphics_Outline_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Themes.Android.CornerRadiusEffect+CornerRadiusOutlineProvider, Xamarin.Forms.Theme.Android", CornerRadiusEffect_CornerRadiusOutlineProvider.class, __md_methods);
	}


	public CornerRadiusEffect_CornerRadiusOutlineProvider ()
	{
		super ();
		if (getClass () == CornerRadiusEffect_CornerRadiusOutlineProvider.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Themes.Android.CornerRadiusEffect+CornerRadiusOutlineProvider, Xamarin.Forms.Theme.Android", "", this, new java.lang.Object[] {  });
	}


	public void getOutline (android.view.View p0, android.graphics.Outline p1)
	{
		n_getOutline (p0, p1);
	}

	private native void n_getOutline (android.view.View p0, android.graphics.Outline p1);

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
