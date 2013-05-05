using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Azureoid
{
	[Activity(Label = "Azureoid", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			
			var button = FindViewById<Button>(Resource.Id.AzureCall);
			button.Click += (sender, args) =>
			{
				var input = Assets.Open("Azure.publishsettings");
				var xdoc = XDocument.Load(input);
				var subscription = xdoc.Descendants("Subscription").Single();
				var id = subscription.Attribute("Id").Value;
			
				var certificate = AssetManagement.GetCertificate(xdoc);
				var serviceList = AzureHelper.GetRunningServices(certificate, id);

				var label = FindViewById<TextView>(Resource.Id.textView1);
				label.Text = serviceList;
			};
		}
	}

}


