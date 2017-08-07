using System;
using AVFoundation;
using BodyCam.iOS.CustomRenderers;
using BodyCam.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CameraView), typeof(CameraViewRenderer))]
namespace BodyCam.iOS.CustomRenderers
{

    public class CameraViewRenderer : ViewRenderer<CameraView, UICameraView>
    {

		UICameraView uiCameraView;

		protected override void OnElementChanged(ElementChangedEventArgs<CameraView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
                uiCameraView = new UICameraView(e.NewElement.Camera);
				SetNativeControl(uiCameraView);
			}
			if (e.OldElement != null)
			{
				// Unsubscribe
				uiCameraView.Tapped -= OnCameraPreviewTapped;
			}
			if (e.NewElement != null)
			{
				// Subscribe
				uiCameraView.Tapped += OnCameraPreviewTapped;
			}
		}

		void OnCameraPreviewTapped(object sender, EventArgs e)
		{
             
			if (uiCameraView.IsPreviewing)
			{
				uiCameraView.CaptureSession.StopRunning();
				uiCameraView.IsPreviewing = false;
			}
			else
			{
				uiCameraView.CaptureSession.StartRunning();
				uiCameraView.IsPreviewing = true;
			}
		}
    }
}
