using Agenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
		public ContactsPage ()
		{
			InitializeComponent ();
            LoadContacts();
		}

        private void LoadContacts()
        {
            var contactList = new List<Contact>
            {
                new Contact{ FullName = "Samuel Pastrana", Email = "s@gmail.com", LinkedIn = "Samuel", PhoneNumber = "304786054", SkypeId = "SamuelP", imageUrl=""},

                new Contact{ FullName = "Samuel Pastrana2", Email = "s@gmail2.com", LinkedIn = "Samuel2", PhoneNumber = "304786054a", SkypeId = "SamuelP2", imageUrl=""},

                new Contact{ FullName = "Samuel Pastrana3", Email = "s@gmail3.com", LinkedIn = "Samuel3", PhoneNumber = "304786054s", SkypeId = "SamuelP3", imageUrl=""},

                new Contact{ FullName = "Samuel Pastrana4", Email = "s@gmail4.com", LinkedIn = "Samuel4", PhoneNumber = "304786054d", SkypeId = "SamuelP4", imageUrl=""},

                new Contact{ FullName = "Samuel Pastrana5", Email = "s@gmail5.com", LinkedIn = "Samuel5", PhoneNumber = "304786054f", SkypeId = "SamuelP5", imageUrl=""}
            };

            lsContacts.ItemsSource = contactList;
        }

    }

}