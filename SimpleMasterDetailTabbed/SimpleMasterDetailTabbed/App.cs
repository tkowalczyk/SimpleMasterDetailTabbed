using System;
using Xamarin.Forms;

namespace SimpleMasterDetailTabbed
{
	public class App : Application
	{
		private static Page _NavPage;
		public static Page RootPage()
		{
			_NavPage = new MainView();

			return _NavPage;
		}
	}
}

