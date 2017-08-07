using System;
using Xamarin.Forms;

namespace BodyCam.Views
{
    public class CameraView : View
    {


    public static readonly BindableProperty CameraProperty = BindableProperty.Create(
	propertyName: "Camera",
	returnType: typeof(CameraOptions),
	declaringType: typeof(CameraView),
	defaultValue: CameraOptions.Back);

		public CameraOptions Camera
		{
			get { return (CameraOptions)GetValue(CameraProperty); }
			set { SetValue(CameraProperty, value); }
		}
        }
}
