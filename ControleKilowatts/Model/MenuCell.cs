using System;

using Xamarin.Forms;

namespace ControleKilowatts
{
	public class MenuCell : ContentPage
	{
		public MenuCell()
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


