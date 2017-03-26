using Android.App;
using Android.Widget;
using Android.OS;

namespace xWeather.Droid
{
    [Activity(Label = "xWeather.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private EditText cityName;
        private Button getWetherButton;
        


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            cityName = FindViewById<EditText>(Resource.Id.cityName);
            getWetherButton = FindViewById<Button>(Resource.Id.getWether);


            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            getWetherButton.Click += GetWetherButton_Click;

        }

        private void GetWetherButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}

