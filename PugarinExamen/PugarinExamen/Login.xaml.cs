using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PugarinExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)

        {
            try{
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                if (usuario == "estudiante2021" && clave == "uisrael2021")
                {
                    await Navigation.PushAsync(new Registro(usuario));
                }
                else
                {
                    await DisplayAlert("Datos Incorrectos","Usuario y/o contraseña incorrecta","ok");
                
}
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de alerta", ex.Message, "ok");
            }
        }
    }
}