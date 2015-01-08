using System;
using Xamarin.Forms;

namespace SimpleMasterDetailTabbed
{
	public class PageOneView : BaseView
	{
		public PageOneView ()
		{
			this.Content = new Label {
				Text = "PageOne View!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}