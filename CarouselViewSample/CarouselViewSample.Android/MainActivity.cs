using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using System.Security.AccessControl;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CarouselViewSample.Droid;
using Android.Content;
using AndroidX.ViewPager.Widget;

[assembly: ExportRenderer(typeof(CarouselView), typeof(CustomCarouselViewRenderer))]
namespace CarouselViewSample.Droid
{
    [Activity(Label = "ExistingSQLiteDbSample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
    public class CustomCarouselViewRenderer : CarouselViewRenderer
    {
        public CustomCarouselViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ItemsView> e)
        {
            base.OnElementChanged(e);


            if (e.NewElement != null)
            {
                var carouselView = (CarouselView)Element;
                var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);

                viewPager.OffscreenPageLimit = carouselView.PeekAreaInsets.Left + carouselView.PeekAreaInsets.Right;
            }
        }
    }
}
