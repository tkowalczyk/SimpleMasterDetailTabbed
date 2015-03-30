using System;
using Xamarin.Forms;

namespace SimpleMasterDetailTabbed
{
	public class AboutView : BaseView
	{
		public AboutView ()
		{
			this.Content = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				Children = {
					new Label {
						Text = "About View!",
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