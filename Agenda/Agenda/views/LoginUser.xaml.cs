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
	public partial class LoginUser : ContentPage
	{
		public LoginUser ()
		{
			InitializeComponent ();
		}

        private async void Ingresar_clicked(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                await DisplayAlert("Validacion", "El nombre de usuario es requerido", "OK");
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                await DisplayAlert("Validacion", "El Password es requerida", "OK");
                txtPassword.Focus();
                return;
            }

            await Navigation.PushAsync(new ContactsPage());

        }
    }
}