using System;

namespace Azureoid
{
	/// <summary>
	/// Represents an item on the main menu
	/// </summary>
	public class MainMenuItemViewModel
	{
		public MainMenuItemViewModel ()
		{
		}

		public string Title {get; set;}
		public int ImageResouceId { get; set;}
		public int? ItemCount {get; set;}
	}
}

