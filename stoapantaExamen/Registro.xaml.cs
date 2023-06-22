using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace stoapantaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuario;

        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuario;
            this.usuario = usuario;
        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double Mensual;
            double fijo;
            fijo = (1800.0 - montoInicial)/3;

            Mensual = fijo + (fijo * 0.05);
            txtMontoMensual.Text = Mensual.ToString();
            
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
             
            
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            
            string pais = pPais.Items[pPais.SelectedIndex];
            string ciudad = pCiudad.Items[pCiudad.SelectedIndex];
            double inicial = Convert.ToDouble(txtMontoInicial);
            double mensual = Convert.ToDouble(txtMontoMensual);

            Navigation.PushAsync(new Resumen(usuario, nombre, apellido, edad, pais, ciudad, inicial, mensual));

        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            //try
            //{
            //    double dato = Convert.ToDouble(txtMontoInicial);
            //    if (dato > 100 || dato < 100)
            //    {
            //        DisplayAlert("Error", "El monto debe ser mayor de 100 y menor de 1800", "Cerrar");
            //        txtMontoInicial.Text = "";
            //    }
            //}
            //catch (Exception) { }
        }
    }
}