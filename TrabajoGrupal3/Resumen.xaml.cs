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
	public partial class Resumen : ContentPage
	{
		public Resumen (String usuario, String nombre, String montotal)
		{
			InitializeComponent ();
            lblUsuario.Text = "Usuario conectado: " + usuario;
            lblNombre.Text = "Nombre del Estudiante: " + nombre;
			lblTotal.Text = "Total a Pagar: " + montotal;
        }
	}
}