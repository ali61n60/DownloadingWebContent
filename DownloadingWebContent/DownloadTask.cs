using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.IO;
using Java.Net;
using Object = Java.Lang.Object;

namespace DownloadingWebContent
{
    public class DownloadTask:AsyncTask<string,int,string>
    {
        protected override string RunInBackground(params string[] @params)
        {
            string result = "";
            try
            {
                var url = new URL(@params[0]);
                var urlConnection = (HttpURLConnection)url.OpenConnection();
                Stream inputStream=urlConnection.InputStream;
                InputStreamReader reader=new InputStreamReader(inputStream);
                int data = reader.Read();
                while (data != -1)
                {
                    char current = (char) data;
                    result += current;
                    data = reader.Read();
                }
            }
            catch (Exception e)
            {
                return "Failed";
            }
            return result;
        }
    }
}