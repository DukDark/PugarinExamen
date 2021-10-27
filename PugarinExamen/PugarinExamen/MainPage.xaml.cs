 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PugarinExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            try {
                await Navigation.PushAsync(new Login());
            
            }
            catch(Exception ex) {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "ok");
            
            }

        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {

        }
    }
}
