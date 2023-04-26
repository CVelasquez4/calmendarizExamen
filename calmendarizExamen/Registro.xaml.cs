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
    public partial class Registro : ContentPage
    {
        public Registro(string Usuario)
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(txtPago.Text) > 3000))
            {
                txtPago.Text = "";
                DisplayAlert("Error en el ingreso de pago", "El pago no puede ser mayor a 3000$", "Cerrar");
            }
            else if ((Convert.ToDouble(txtPago.Text) <= 3000)) 
            {
                double saldo = 3000 - (Convert.ToDouble(txtPago.Text));
                double interes = 3000 * 0.5;
                double cuota = (saldo + interes) / 3;
                lblPago.Text = cuota.ToString();

            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(txtPago.Text) > 3000))
            {
                txtPago.Text = "";
                DisplayAlert("Error en el ingreso de pago", "El pago no puede ser mayor a 3000$", "Cerrar");
            }
            else if ((Convert.ToDouble(txtPago.Text) <= 3000))
            {
                DisplayAlert("Exito", "Elemento Guardado con exito", "Cerrar");
                

            }

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(txtPago.Text) > 3000))
            {
                txtPago.Text = "";
                DisplayAlert("Error en el ingreso de pago", "El pago no puede ser mayor a 3000$", "Cerrar");
            }
            else if ((Convert.ToDouble(txtPago.Text) <= 3000))
            {
                double pagot = (Convert.ToDouble(txtPago.Text)) + ((Convert.ToDouble(lblPago.Text)) * 3);
                string Nombre = txtNombre.Text;
                double Pagototal = pagot;
                Navigation.PushAsync(new Resumen(Nombre, Pagototal));

            }
            
        }
    }
}