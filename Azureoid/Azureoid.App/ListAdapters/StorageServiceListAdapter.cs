using System;
using System.Linq;
using Android.Widget;
using Android.App;
using Azureoid.Core.DomainObjects;

namespace Azureoid
{
	public class StorageServiceListAdapter : BaseAdapter<StorageServicesStorageService>
	{
		StorageServices _storageServices;
		Activity _activity;
		
		public StorageServiceListAdapter (Activity activity)
		{
			_activity = activity;
			_storageServices = new StorageServices();
		}
		
		public StorageServiceListAdapter (Activity activity, StorageServices storageServices) : this (activity)
		{
			_storageServices = storageServices;
		}
		
		#region implemented abstract members of BaseAdapter
		public override long GetItemId (int position)
		{
			return position;
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			var view = convertView ?? _activity.LayoutInflater.Inflate (
				Resource.Layout.StorageServiceListItem, parent, false);
			
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

		#region implemented abstract members of BaseAdapter
		public override StorageServicesStorageService this [int position] {
			get {
				return _storageServices.StorageService[position];
			}
		}
		#endregion
		
	}
}

