using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora_XGVC
{
    public partial class MainPage : ContentPage
    {
        private string n1 = "";
        private string n2 = "";
        private string operador = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void ActualizarPantalla()
        {
            lblNumber.Text = n1 + operador + n2;
        }

        private void Click_seven(object sender, EventArgs e)
        {
            AgregarNumero("7");
        }

        private void Click_eight(object sender, EventArgs e)
        {
            AgregarNumero("8");
        }

        private void Click_nine(object sender, EventArgs e)
        {
            AgregarNumero("9");
        }

        private void Click_four(object sender, EventArgs e)
        {
            AgregarNumero("4");
        }

        private void Click_five(object sender, EventArgs e)
        {
            AgregarNumero("5");
        }

        private void Click_six(object sender, EventArgs e)
        {
            AgregarNumero("6");
        }

        private void Click_one(object sender, EventArgs e)
        {
            AgregarNumero("1");
        }

        private void Click_two(object sender, EventArgs e)
        {
            AgregarNumero("2");
        }

        private void Click_three(object sender, EventArgs e)
        {
            AgregarNumero("3");
        }

        private void Click_zero(object sender, EventArgs e)
        {
            AgregarNumero("0");
        }

       

        private void AgregarNumero(string numero)
        {
            if (string.IsNullOrEmpty(operador))
            {
                n1 += numero;
            }
            else
            {
                n2 += numero;
            }

            ActualizarPantalla();
        }

        
    }
}
