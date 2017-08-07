using BodyCam.Views;
using Plugin.Media;
using Xamarin.Forms;

namespace BodyCam
{
    public partial class BodyCamPage : ContentPage
    {
        public BodyCamPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }



		void Handle_Clicked(object sender, System.EventArgs e)
		{
            var next = new ContentPage();
            next.Content = new CameraView();
           Navigation.PushAsync(next);

        }


        //void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    CrossMedia.Current.Initialize();


        //    if(CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakeVideoSupported){
        //        RecordVideo();
        //    }
        //}

        //private async void RecordVideo(){
        //    var file = await CrossMedia.Current.TakeVideoAsync(new Plugin.Media.Abstractions.StoreVideoOptions
        //    {
        //        Directory = "Sample",
        //        Name = "Test"
        //    });
        //}
    }
}
