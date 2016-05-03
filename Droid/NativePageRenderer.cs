using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.Views;
using formsSample;
using formsSample.Droid;

[assembly:ExportRenderer(typeof(NativelyRenderedPage), typeof(NativePageRenderer))]
namespace formsSample.Droid
{
    public class NativePageRenderer : PageRenderer
    {
        Android.Views.View view;

        protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Page> e)
        {
            base.OnElementChanged (e);

            //// var page = e.NewElement as MySecondPage;

            // this is a ViewGroup - so should be able to load an AXML file and FindView<>
            var activity = this.Context as Activity;

            var o = activity.LayoutInflater.Inflate(Resource.Layout.MyAndroidLayout, this, false);
            view = o;

            AddView(view);
        }

        protected override void OnLayout (bool changed, int l, int t, int r, int b)
        {
            //// base.OnLayout (changed, l, t, r, b);
            var msw = MeasureSpec.MakeMeasureSpec (r - l, MeasureSpecMode.Exactly);
            var msh = MeasureSpec.MakeMeasureSpec (b - t, MeasureSpecMode.Exactly);
            view.Measure(msw, msh);
            view.Layout (0, 0, r - l, b - t);
        }

    }
}

