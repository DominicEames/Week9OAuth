using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace W9OAuth.Droid
{
    [Activity(Label = "CustomUrlSchemeInterceptorActivity", NoHistory = true, LaunchMode = LaunchMode.SingleTop)]
[ IntentFilter (
    new[] {Intent.ActionView },
    Categories = new[] {Intent.CategoryDefault, Intent.CategoryBrowsable },
    DataSchemes = new[] {"com.googleusercontent.apps.246293466687-vb7sfp0omrkup08nhprt1641u30olt3g:/oauth2redirect"},
    DataPath ="/oauth2redirect")]
    public class CustomUrlSchemeInterceptorActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var url = new Uri(Intent.Data.ToString());
            AuthenState.Authenticator.OnPageLoading(url);

            Finish();
        }
    }
}