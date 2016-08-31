using System;

using Xamarin.Forms;

namespace ControleKilowatts
{
	public class MenuListData : ContentPage
	{
		public MenuListData()
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


