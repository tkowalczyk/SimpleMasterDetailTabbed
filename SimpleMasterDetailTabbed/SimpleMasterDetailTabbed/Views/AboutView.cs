using System;
using Xamarin.Forms;

namespace SimpleMasterDetailTabbed
{
	public class AboutView : BaseView
	{
		public AboutView ()
		{
			this.Content = new Label {
				Text = "About View!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}