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
    public partial class Resumen : ContentPage
    {
        public Resumen(usuario, nombre, apellido, edad, pais, ciudad, inicial, mensual)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO: " + usuario;
        }
    }
}