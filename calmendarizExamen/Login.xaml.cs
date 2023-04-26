using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calmendarizExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            if (Usuario == "estudiante2023" && Contraseña == "uisrael2023")
            {
                Navigation.PushAsync(new Registro(Usuario));
            }
            else
            {
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                DisplayAlert("Error", "Usuario y contraseña incorrectos", "Cerrar");
            }

        }
    }
}