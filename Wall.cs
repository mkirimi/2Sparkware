using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace _2SparkWare
{
    [Activity(Label = "_2SparkWare", MainLauncher = true, Icon = "@drawable/icon")]
    public class Wall : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "wall" layout resource
            SetContentView(Resource.Layout.Wall);

            // Get a reference to the button
            var btnSubmitFeedback = FindViewById<Button>(Resource.Id.btnSubmitFeedback);

            // You can use either this short form of StartActivity, which will create 
            // an intent internally, or the long form shown below.           
            //            showSecond.Click += (sender, e) => {           
            //                StartActivity (typeof(SecondActivity));
            //            };

            // Long form of StartActivity with the intent created in code so that
            // data can be added to the message payload using the PutExtra call.          
            btnSubmitFeedback.Click += (sender, e) =>
            {
                var submitFeedback = new Intent(this, typeof(SubmitFeedback));
                //submitFeedback.PutExtra("FirstData", "Data from FirstActivity");
                StartActivity(submitFeedback);
            };
        }
    }
}

