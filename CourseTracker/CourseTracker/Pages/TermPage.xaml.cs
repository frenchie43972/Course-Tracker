using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourseTracker.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TermPage : ContentPage
	{
		public TermPage()
		{
			InitializeComponent();
		}

		async void AddTerm_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AddTerm());

		}
	}
}