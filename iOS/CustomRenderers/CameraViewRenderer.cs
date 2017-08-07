using System;
using AVFoundation;
using BodyCam.iOS.CustomRenderers;
using BodyCam.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CameraView), typeof(CameraPreviewRenderer))]
namespace BodyCam.iOS.CustomRenderers
{

    public class CameraPreviewRenderer : ViewRenderer<CameraView, UICameraPreview>
    {
       
 
    }
}
