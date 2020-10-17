using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BLINK.Droid.Controller
{
    public static class Functions
    {
        public static void ShowToast(string str, ToastLength length = ToastLength.Short)
        {
            if (App.Current.Dispatcher.IsInvokeRequired)
            {
                App.Current.Dispatcher.BeginInvokeOnMainThread(() => Toast.MakeText(Application.Context, str, length).Show());
            }
            else
            {
                Toast.MakeText(Application.Context, str, length).Show();
            }
        }
    }
}