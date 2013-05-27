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
using Azureoid.Core.Common;
using Azureoid.Core;

//TODO: Find a better way to serialize these objects or 
using StorageKeys = Azureoid.Core.DomainObjects.StorageKeys;

namespace Azureoid
{
    [Activity(Label = "Azureoid", MainLauncher = true, Icon = "@drawable/Azureoid")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.MainMenu);

			var list = FindViewById<ListView> (Resource.Id.ServiceList);
			var services = new List<MainMenuItemViewModel> {
				new MainMenuItemViewModel {Title = "Websites", ImageResouceId = Resource.Drawable.IconWebsites, ItemCount = 2},
				new MainMenuItemViewModel {Title = "Virtual Machines", ImageResouceId = Resource.Drawable.IconVirtualMachine},
				new MainMenuItemViewModel {Title = "Mobile Services", ImageResouceId = Resource.Drawable.IconMobileServices},
				new MainMenuItemViewModel {Title = "Cloud Services", ImageResouceId = Resource.Drawable.IconCloudServices},
				new MainMenuItemViewModel {Title = "SQL Azure", ImageResouceId = Resource.Drawable.IconSql},
				new MainMenuItemViewModel {Title = "Storage", ImageResouceId = Resource.Drawable.IconStorage},
				new MainMenuItemViewModel {Title = "Network", ImageResouceId = Resource.Drawable.IconNetwork},
				new MainMenuItemViewModel {Title = "Media Services", ImageResouceId = Resource.Drawable.IconMediaServices},
				new MainMenuItemViewModel {Title = "Settings", ImageResouceId = Resource.Drawable.IconSettings}
			};

			list.Adapter = new MainMenuListAdapter (this, services);

        }


    }

}


