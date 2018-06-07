using ContactBook.Models;
using ContactBook.Service;
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
	public partial class ContactsPage : ContentPage
	{

        private ContactsService _contactService;
        private bool ShowHideContactDetails = false;

        public ContactsPage ()
		{
			InitializeComponent ();
            _contactService = new ContactsService();
		}

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lvContacts.ItemsSource = _contactService.GetContacts(e.NewTextValue);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ShowHideContactDetails = !ShowHideContactDetails;
        }
    }
}