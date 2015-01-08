using System;
using Xamarin.Forms;

namespace SimpleMasterDetailTabbed
{
	public class FeedbackView : BaseView
	{
		public FeedbackView ()
		{
			this.Content = new Label {
				Text = "Feedback View!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}