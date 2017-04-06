using Android.App;
using Android.Widget;
using Android.OS;

namespace ProvaXamarinAndroid
{
    [Activity(Label = "ProvaXamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int contador = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            contador += 1;

            Button bntOla = base.FindViewById<Button>(Resource.Id.bntOla);

            bntOla.Click += delegate { bntOla.Text = string.Concat("Contador de clicks: ", contador); };
        }

    }
}

