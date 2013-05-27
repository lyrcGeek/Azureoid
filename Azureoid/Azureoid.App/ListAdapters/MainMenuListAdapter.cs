using System;
using System.Collections.Generic;
using Android.Widget;
using Android.App;

namespace Azureoid
{
	public class MainMenuListAdapter : BaseAdapter<MainMenuItemViewModel>
	{
		private List<MainMenuItemViewModel> _services;
		private Activity _activity;

		public MainMenuListAdapter (Activity activity)
		{
			_activity = activity;
			_services = new List<MainMenuItemViewModel> ();
		}

		public MainMenuListAdapter (Activity activity, List<MainMenuItemViewModel> services) : this(activity)
		{
			_services = services;
		}


		#region implemented abstract members of BaseAdapter
		public override long GetItemId (int position)
		{
			return position;
		}
		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			var view = convertView ?? _activity.LayoutInflater.Inflate (
				Resource.Layout.MainMenuListItem, parent, false);

			var title = view.FindViewById<TextView> (Resource.Id.ItemTitle);
			var image = view.FindViewById<ImageView> (Resource.Id.ItemImage);
			var itemCount = view.FindViewById<TextView> (Resource.Id.ItemCount);

			var currentItem = _services[position];
			title.Text = currentItem.Title;
			image.SetImageResource (currentItem.ImageResouceId);
			itemCount.Text = currentItem.ItemCount != null 
				? currentItem.ItemCount.ToString()
				: String.Empty;

			return view;
		}
		public override int Count {
			get {
				return _services.Count;
			}
		}
		#endregion
		#region implemented abstract members of BaseAdapter
		public override MainMenuItemViewModel this [int position] {
			get {
				return _services[position];
			}
		}
		#endregion
	}
}

