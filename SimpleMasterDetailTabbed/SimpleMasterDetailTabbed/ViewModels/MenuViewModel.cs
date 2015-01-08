using System;
using System.Collections.ObjectModel;

namespace SimpleMasterDetailTabbed
{
	public class MenuViewModel : BaseViewModel
	{
		#region Properties
		public ObservableCollection<HomeMenuItem> MenuItems { get; set; }
		#endregion

		#region Ctor
		public MenuViewModel()
		{
			CanLoadMore = true;
			Title = "MasterDetailTabbed";
			MenuItems = new ObservableCollection<HomeMenuItem>();

			MenuItems.Add(new HomeMenuItem
				{
					Id = 0,
					Title = "Home",
					MenuType = MenuType.Home,
					Icon = "home.png"
				});
						
			MenuItems.Add(new HomeMenuItem
				{
					Id = 5,
					Title = "Feedback",
					MenuType = MenuType.Feedback,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 6,
					Title = "About",
					MenuType = MenuType.About,
					Icon = "about.png"
				});
		}
		#endregion
	}
}