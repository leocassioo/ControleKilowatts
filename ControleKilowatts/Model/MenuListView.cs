using System;

using Xamarin.Forms;

namespace ControleKilowatts
{
	public class MenuListView : ContentPage
	{
		public MenuListView()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


