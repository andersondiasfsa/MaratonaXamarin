using Android.App;
using Android.Widget;
using Android.OS;

namespace XelloXamarinAndroid
{
    [Activity(Label = "XelloXamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int contador = 0;
        Button bntHello;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            this.bntHello = FindViewById<Button>(Resource.Id.bntHello);
            this.bntHello.Click += BntHello_Click;
        }

        private void BntHello_Click(object sender, System.EventArgs e)
        {
            contador += 1;
             this.bntHello.Text = string.Concat(contador.ToString(), " cliques!");
        }

    }
}

