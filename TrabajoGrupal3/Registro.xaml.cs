using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrabajoGrupal3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String usuario, String contraseña)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: "+ usuario;
            
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Double monto = Convert.ToDouble(txtMonto.Text);
            if (monto <= 0 || monto > 3000)
            {
                DisplayAlert("Ingrese un monto válido", "", "salir");
            }
            else { 
            double faltante = 3000 - monto;
            double rest = faltante / 5;
            double aumento = 0.05*faltante;
            double pagoMensual = aumento + rest;
            
                DisplayAlert("El monto a Pagar es: ","" + pagoMensual.ToString("0.00"),  "salir");
               
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            String usuario = "nombreEstudiante2022";
            String nombre = txtNombre.Text;
            Double monto = Convert.ToDouble(txtMonto.Text);
            Double faltante = 3000 - monto;
            Double rest = faltante / 5;
            Double aumento = 0.05 * faltante;
            Double pagoMensual = aumento + rest;
            Double total = pagoMensual * 5 + monto;
            String montotal = Convert.ToString(total);
            await Navigation.PushAsync(new Resumen(usuario, nombre, montotal));

        }
    }
}