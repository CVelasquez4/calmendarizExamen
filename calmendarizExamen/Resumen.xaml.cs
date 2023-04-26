using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace calmendarizExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(String Nombre, Double Pagototal)
        {
            InitializeComponent();
            lblNomRes.Text = Nombre;
            lblPagRes.Text = Pagototal.ToString("N2");
    
           
        }
    }
}