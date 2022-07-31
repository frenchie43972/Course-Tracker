using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseTracker.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseTracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		async void Terms_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new TermPage());
		}
	}
}