using System;
using System.Linq;
using System.Collections.Generic;
using Android.Widget;
using Android.App;

namespace Azureoid
{
	public class HostedServicesListAdapter : BaseAdapter
	{
		StorageServices _storageServices;
		Activity _activity;

		public HostedServicesListAdapter (Activity activity)
		{
			_activity = activity;
			_storageServices = new StorageServices();
		}

		public HostedServicesListAdapter (Activity activity, StorageServices storageServices) : this (activity)
		{
			_storageServices = storageServices;
		}
		
		#region implemented abstract members of BaseAdapter
		public override Java.Lang.Object GetItem (int position)
		{
			return _storageServices.StorageService[position].ToJavaObject<Object>();
		}
		public override long GetItemId (int position)
		{
			return position;
		}
		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			var view = convertView ?? _activity.LayoutInflater.Inflate (
				Resource.Layout.HostedServiceListItem, parent, false);

			var storageName = view.FindViewById<TextView> (Resource.Id.StorageName);
			var location = view.FindViewById<TextView> (Resource.Id.LocationName);

			var currentItem = _storageServices.StorageService[position];
			storageName.Text = currentItem.ServiceName;
			location.Text = String.Format(" ({0})", currentItem.StorageServiceProperties.GeoPrimaryRegion);

			return view;
		}
		public override int Count {
			get {
				return _storageServices.StorageService.Count();
			}
		}
		#endregion
	}
}

