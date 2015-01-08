using System;
using Xamarin.Forms;

namespace SimpleMasterDetailTabbed
{
	public class MasterView : BaseView
	{
		#region Fields
		private Page pageSelection;
		private MenuType menuType = MenuType.About;

		public Action<MenuType> PageSelectionChanged;
		public Page PageSelection
		{
			get { return pageSelection; }
			set
			{
				pageSelection = value;
				if (PageSelectionChanged != null)
					PageSelectionChanged(menuType);
			}
		}
		#endregion

		#region Menu
		private HomeView home;
		private AboutView about;
		private FeedbackView feedback;
		#endregion

		#region Ctor
		public MasterView(MenuViewModel viewModel)
		{
			this.BindingContext = viewModel;

			this.Title = "Title";

			var layout = new StackLayout { Spacing = 0 };

			var listView = new ListView();

			var cell = new DataTemplate(typeof(ImageCell));

			cell.SetBinding(TextCell.TextProperty, MenuViewModel.TitlePropertyName);
			cell.SetBinding(ImageCell.ImageSourceProperty, "Icon");

			listView.ItemTemplate = cell;

			listView.ItemsSource = viewModel.MenuItems;
			if (about == null)
				about = new AboutView();

			PageSelection = about;

			listView.ItemSelected += (sender, args) =>
			{
				var menuItem = listView.SelectedItem as HomeMenuItem;
				menuType = menuItem.MenuType;
				switch (menuItem.MenuType)
				{
				case MenuType.Home:
					if (home == null)
						home = new HomeView();

					PageSelection = home;
					break;
				case MenuType.About:
					if (about == null)
						about = new AboutView();

					PageSelection = about;
					break;
				case MenuType.Feedback:
					if (feedback == null)
						feedback = new FeedbackView();

					PageSelection = feedback;
					break;
				}
			};

			listView.SelectedItem = viewModel.MenuItems[0];
			layout.Children.Add(listView);

			this.Content = layout;
		}
		#endregion
	}
}