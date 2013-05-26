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

			var list = FindViewById<ListView> (Resource.Id.listView1);

        }


    }

}


