using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace IFS_AutoSample
{
    [Activity(Label = "POC TestApp", MainLauncher = true, Icon = "@drawable/icon")]
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
            password.InputType = Android.Text.InputTypes.TextVariationPassword |
                          Android.Text.InputTypes.ClassText;

            button.Click += delegate
            {
                if (userName.Text == "admin" && password.Text == "welcome@123")
                {
					StartActivity(typeof(HomeActivity));
					//var msgDiaglog = new AlertDialog.Builder(this);
					//msgDiaglog.SetMessage("Login Successfull");
					//msgDiaglog.SetPositiveButton("OK", (senderAlert, args) =>
					//{
					//	// write your own set of instructions
					//});
					//msgDiaglog.Show();

                    //lblResult.Text = "Login Successfull";
                }
                else
                {
					var msgDiaglog = new AlertDialog.Builder(this);
					msgDiaglog.SetMessage("Login Failed");
					msgDiaglog.SetPositiveButton("OK", (senderAlert, args) =>
					{
						// write your own set of instructions
					});
					msgDiaglog.Show();
                    //lblResult.Text = "Login Failed";
                }
            };
        }
    }
}

