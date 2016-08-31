using System;

using Xamarin.Forms;

namespace ControleKilowatts
{
	public class MenuItem : ContentPage
	{
		public MenuItem()
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


