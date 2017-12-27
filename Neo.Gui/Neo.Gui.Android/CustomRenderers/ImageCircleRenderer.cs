using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FFImageLoading.Forms;
using FFImageLoading.Forms.Droid;
using Neo.Gui.Droid.CustomRenderers;
using Neo.Gui.XamarinViews.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;
using View = Android.Views.View;


[assembly: ExportRenderer(typeof(ImageCircle), typeof(ImageCircleRenderer))]

namespace Neo.Gui.Droid.CustomRenderers
{
    /// <summary>
    ///     ImageCircle Implementation
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ImageCircleRenderer : CachedImageRenderer
    {
        public ImageCircleRenderer()
        {
            SetBackgroundColor(Color.Transparent);
        }

        /// <summary>
        ///     Used for registration with dependency service
        /// </summary>
        public new static void Init()
        {
            var temp = DateTime.Now;
        }

        /// <summary>
        /// </summary>
        /// <param name="e"></param>
        protected override void OnElementChanged(ElementChangedEventArgs<CachedImage> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
                if ((int)Build.VERSION.SdkInt < 21)
                    SetLayerType(LayerType.Software, null);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ImageCircle.BorderColorProperty.PropertyName ||
                e.PropertyName == ImageCircle.BorderThicknessProperty.PropertyName)
                //e.PropertyName == ImageCircle.FillColorProperty.PropertyName)
                Invalidate();
        }


        /// <summary>
        /// </summary>
        /// <param name="canvas"></param>
        /// <param name="child"></param>
        /// <param name="drawingTime"></param>
        /// <returns></returns>
        protected override bool DrawChild(Canvas canvas, View child, long drawingTime)
        {
            try
            {
                var radius = Math.Min(Width, Height) / 2;

                var borderThickness = (float)((ImageCircle)Element).BorderThickness;

                var strokeWidth = 0;

                if (borderThickness > 0)
                {
                    var logicalDensity = Forms.Context.Resources.DisplayMetrics.Density;
                    strokeWidth = (int)Math.Ceiling(borderThickness * logicalDensity + .5f);
                }

                radius -= strokeWidth / 2;


                var path = new Path();
                path.AddCircle(Width / 2.0f, Height / 2.0f, radius, Path.Direction.Ccw);

                // canvas.DrawColor(Android.Graphics.Color.Red);
                canvas.Save();
                canvas.ClipPath(path);


                var paint = new Paint();
                paint.AntiAlias = true;
                paint.SetStyle(Paint.Style.Fill);
                paint.Color = Color.White;
                canvas.DrawPath(path, paint);
                paint.Dispose();

                var result = base.DrawChild(canvas, child, drawingTime);
                canvas.Restore();

                path = new Path();
                path.AddCircle(Width / 2, Height / 2, radius, Path.Direction.Ccw);


                if (strokeWidth > 0.0f)
                {
                    paint = new Paint();
                    paint.AntiAlias = true;
                    paint.StrokeWidth = strokeWidth;
                    paint.SetStyle(Paint.Style.Stroke);
                    paint.Color = ((ImageCircle)Element).BorderColor.ToAndroid();
                    canvas.DrawPath(path, paint);
                    paint.Dispose();
                }

                path.Dispose();
                //  this.Invalidate();
                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Unable to create circle image: " + ex);
            }
            //this.Invalidate();
            return base.DrawChild(canvas, child, drawingTime);
        }
    }
}