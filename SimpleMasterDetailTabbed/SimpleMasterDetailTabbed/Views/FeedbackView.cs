using System;
using Xamarin.Forms;

namespace SimpleMasterDetailTabbed
{
	public class FeedbackView : BaseView
	{
		public FeedbackView ()
		{
			Grid mainGrid = new Grid()
			{
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				RowSpacing = 0,
				ColumnSpacing = 0,
				Padding = 0,
				RowDefinitions = 
				{
					new RowDefinition { Height = GridLength.Auto},
					new RowDefinition { Height = GridLength.Auto}
				},
				ColumnDefinitions = 
				{
					new ColumnDefinition { Width = GridLength.Auto}
				}
				};

			Image myImage = new Image()
			{
				Aspect = Aspect.AspectFill,
				HeightRequest = 150,
				MinimumHeightRequest = 150,
				Source = ImageSource.FromFile(
					"Image.png"
				),
			};

			Label myLabel = new Label {
				Text = "Feedback View!"
			};

			mainGrid.Children.Add(myImage, 0, 0);
			mainGrid.Children.Add(myLabel, 0, 1);

			this.Content = mainGrid;
		}
	}
}