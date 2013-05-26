using System;
using Android.App;
using Android.Widget;
using System.Xml.Linq;
using System.Linq;
using Azureoid.Core.Common;
using Azureoid.Core;

namespace Azureoid
{
	public class StorageServiceController : Activity
	{
		public StorageServiceController ()
		{
		}

		/// <summary>
		/// This is just a temporary place to put this code here as I test on MainActivity
		/// </summary>
		public void TemporaryHolder()
		{
			//TODO: Stop using anonymous delegates, this is not javascipt :P
			//TODO: Find a pattern to distribute all these events in an orderly way!
			var button = FindViewById<Button> (Resource.Id.AzureCall);
			button.Click += (sender, args) =>
			{
				var input = Assets.Open ("Azure.publishsettings");
				var xdoc = XDocument.Load (input);
				var subscription = xdoc.Descendants ("Subscription").Single ();
				var id = subscription.Attribute ("Id").Value;

				AssetManagement.GetCertificate (xdoc);
				var services = AzureHelper.GetStorageAccounts (id);

				//var servicesAsStrings = services.StorageService.Select (l => l.ServiceName).ToList();

				var storageList = FindViewById<ListView> (Resource.Id.StorageAccountList);
				storageList.Adapter = new StorageServiceListAdapter (this, services);

				storageList.ItemClick += (listSender, e) =>
				{
					var list = listSender as ListView;
					var item = services.StorageService [e.Position];

					//var storageAccount = AzureHelper.GetStorageAccountKeys (id, item.ServiceName) as StorageKeys.StorageService;
					//Toast.MakeText (this, storageAccount.StorageServiceKeys.Primary, ToastLength.Short).Show ();
				};
			};
		}
	}
}

