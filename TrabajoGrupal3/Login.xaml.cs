using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrabajoGrupal3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            
            String usuario = txtUsuario.Text;
            String contraseña = txtContraseña.Text;

            if (usuario == "nombreEstudiante2022" && contraseña == "itq2022")
            {
                await Navigation.PushAsync(new Registro(usuario, contraseña));
            }
            else {
                DisplayAlert("Usuario o Contraseña incorrecta", "Intente de nuevo", "Salir");
            }
                
            
            
                
            
            
            

        }
    }
}