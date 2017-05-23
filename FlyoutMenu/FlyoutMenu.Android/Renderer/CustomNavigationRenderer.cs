using Android.App;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics.Drawables;
using FlyoutMenu.Droid.Renderer;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationRenderer))]
namespace FlyoutMenu.Droid.Renderer
{
    //Customize the Menu button on Android
    public class CustomNavigationRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        {
            base.OnElementChanged(e);
            e.NewElement.BarBackgroundColor = Color.FromHex("E57EA6");
            AddAppIconFromActionBar();
        }
        void AddAppIconFromActionBar()
        {
            var actionBar = ((Activity)Context).ActionBar;
            actionBar.SetIcon(Resource.Drawable.ic_menu);
        }
    }
}