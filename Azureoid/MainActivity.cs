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

			//TODO: Stop using anonymous delegates, this is not javascipt :P
			//TODO: Find a pattern to distribute all these events in an orderly way!
			var button = FindViewById<Button>(Resource.Id.AzureCall);
			button.Click += (sender, args) =>
			{
				var input = Assets.Open("Azure.publishsettings");
				var xdoc = XDocument.Load(input);
				var subscription = xdoc.Descendants("Subscription").Single();
				var id = subscription.Attribute("Id").Value;
			
				var certificate = AssetManagement.GetCertificate(xdoc);
				var services = AzureHelper.GetStorageAccounts(certificate, id);

				//var servicesAsStrings = services.StorageService.Select (l => l.ServiceName).ToList();

				var storageList = FindViewById<ListView>(Resource.Id.StorageAccountList);
				storageList.Adapter = new StorageServiceListAdapter(this, services);

				storageList.ItemClick += (object listSender, AdapterView.ItemClickEventArgs e) => {
					var list = listSender as ListView;
					var item = services.StorageService[e.Position];

					var storageAccount = AzureHelper.GetStorageAccountKeys(certificate, id, item.ServiceName) as Azureoid.DomainObjects.StorageKeys.StorageService;

					Android.Widget.Toast.MakeText(this, storageAccount.StorageServiceKeys.Primary, 
					                              Android.Widget.ToastLength.Short).Show();
				};

			};
		}
	}

}


