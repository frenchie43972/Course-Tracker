using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CourseTracker.Services;

namespace CourseTracker.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddTerm : ContentPage
	{
		public AddTerm()
		{
			InitializeComponent();
		}

		private void AddStartDate_DateSelected(object sender, DateChangedEventArgs e)
		{

		}

		private void AddEndDate_DateSelected(object sender, DateChangedEventArgs e)
		{

		}

		async void SaveButton_Clicked(object sender, EventArgs e)
		{
			//await DatabaseServices.Update
		}
	}
}