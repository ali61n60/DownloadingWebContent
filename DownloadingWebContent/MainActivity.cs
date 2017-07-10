using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace DownloadingWebContent
{
    [Activity(Label = "DownloadingWebContent", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            DownloadTask task=new DownloadTask();
            string result= task.Execute("https://www.google.com").GetResult();
            Log.Info("Google", result);
        }
    }
}

