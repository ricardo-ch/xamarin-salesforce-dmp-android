using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Com.Krux.Androidsdk.Aggregator;

namespace Ricardo.Salesforce.DMP.Android.Sample
{
    [Activity(Label = "Ricardo.Salesforce.DMP.Android.Sample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        const string configId = "config-id";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += OnButtonClick;

            KruxEventAggregator.Initialize(this, configId, new KruxSegment(), true);
            Bundle pageAttribute = new Bundle();
            Bundle userAttribute = new Bundle();
            KruxEventAggregator.TrackPageView("main_page", pageAttribute, userAttribute);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {

            Bundle bundle = new Bundle();
            bundle.PutString("event_id", "YOUR_EVENT_ID");
            bundle.PutInt("click_count", count);
            KruxEventAggregator.FireEvent("ButtonClick", bundle);
            count++;


        }
    }

    internal class KruxSegment : Java.Lang.Object, IKruxSegments
    {

        public void GetSegments(string p0)
        {
            // Insert your code here
        }
    }
}

