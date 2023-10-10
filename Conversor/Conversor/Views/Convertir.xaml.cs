using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        private double cm;
        private double m;

        public Convertir()
        {
            InitializeComponent();
        }

        private void btn_Volver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Calcular()
        {
            if(!string.IsNullOrEmpty(txt_Numero.Text))
            {
                cm = Convert.ToDouble(txt_Numero.Text);
                m = cm / 100;
                lbl_Resultado.Text = m.ToString() + " m";
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad.", "OK");
            }
        }

        private void btn_Calcular_Clicked(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}