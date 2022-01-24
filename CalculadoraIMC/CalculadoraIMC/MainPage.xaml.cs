using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var peso = double.Parse(Peso.Text);
                var altura = double.Parse(Altura.Text);
                var imc = peso / (altura*altura);
                aclaracionUsuario(imc);
                IMC.Text = imc.ToString();
            }
            else
            {
                string mensaje = "Datos erroneos, porfavor rellena todos los campos";
                DisplayAlert("Error", mensaje, "Ok");
            }
           


        }

        public void aclaracionUsuario(double imc)
        {
            string resultado = "heeeeeyyyy";
            if(imc < 18.5)
            {
                resultado = "Tu peso es bajo";
            }else if (imc >=18.5 && imc <=24.9)
            {
                resultado = "Tu peso es normal";
            }
            else if(imc >= 25 )
            {
                resultado = "Tu peso es alto";
            }
            DisplayAlert("Resultado", resultado, "Ok");
        }
    }
}
