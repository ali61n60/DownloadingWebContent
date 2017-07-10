﻿using Android.App;
using Android.Widget;
using Android.OS;

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
            task.Execute("http://www.asriran.com");
            
        }
    }
}

