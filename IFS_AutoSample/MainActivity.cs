using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace IFS_AutoSample
{
    [Activity(Label = "IFS_AutoSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            EditText userName = FindViewById<EditText>(Resource.Id.userName);
            EditText password = FindViewById<EditText>(Resource.Id.password);
            TextView lblResult = FindViewById<TextView>(Resource.Id.lblResult);

            button.Click += delegate
            {
                if (userName.Text == "ganesh" && password.Text == "ganesh")
                {
                    lblResult.Text = "Login Successfull";
                }
                else
                {
                    lblResult.Text = "Login Failed";
                }
            };
        }
    }
}

