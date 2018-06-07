using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactBook.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecentPage : ContentPage
	{
		public RecentPage ()
		{
			InitializeComponent ();
		}
	}
}