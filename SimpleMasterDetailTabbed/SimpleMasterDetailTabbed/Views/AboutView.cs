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
						Command = new Command(p => 
							{
//								Solution #1
//								MainView mv = new MainView();
//								mv.Detail = new NavigationPage(new FeedbackView());
//
//								App.Current.MainPage = mv;

//								Solution #2
								FeedbackView fv = new FeedbackView();

								MessagingCenter.Send<FeedbackView> (fv, "OpenInDetail");
							})
					}
				}
			};
		}
	}
}