using System;
using Xamarin.Forms;

namespace SimpleMasterDetailTabbed
{
	public class PageOneView : BaseView
	{
		public PageOneView ()
		{
			this.Content = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				Children = {
					new Label {
						Text = "PageOne View!",
						VerticalOptions = LayoutOptions.CenterAndExpand,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
					},
					new Button {
						Text = "Show FeedbackView",
						Command = new Command(() => 
							{
								this.Navigation.PushAsync(new FeedbackView());
							})
					}
				}
			};
		}
	}
}