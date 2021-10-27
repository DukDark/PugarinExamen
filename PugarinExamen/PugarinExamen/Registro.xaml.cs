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
    public partial class Registro : ContentPage
    {
        double costo = 1800;
        string usuariolog;
        double total;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            usuariolog = usuario;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double porciento = costo * 0.05;
                double monto = Convert.ToDouble(txtMont1.Text);

                if (monto >= 1 && monto <= 1800)
                {
                    double cuota = ((costo - monto) / 3) + porciento;
                    total = monto + (cuota * 3);

                    txtCuota1.Text = cuota.ToString();
                    txtCuota2.Text = cuota.ToString();
                    txtCuota3.Text = cuota.ToString();
                }
                else 
                {
                    await DisplayAlert("Datos Incorrectos", "El monto inicial debe ser entre 1 y 1800", "ok");
                }
            }
            catch (Exception ex) {

                await DisplayAlert("Mensaje de alerta", ex.Message, "ok");

            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await DisplayAlert("Listo", "Elemento guardado con exito", "ok");
                await Navigation.PushAsync(new Resumen(lblUsuario.Text, txtNombre.Text, total));
            }

            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de alerta", ex.Message, "OK");
            }
        }
    }
}