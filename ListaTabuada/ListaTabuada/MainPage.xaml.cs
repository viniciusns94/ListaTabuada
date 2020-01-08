using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListaTabuada
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Clicked(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(entry_tabuada_Numero.Text);
            List<string> itens = new List<string>();
            string texto = "";
            for(int i = 0; i < 11; i++)
            {
                texto = n + " X " + i + " = " + (n * i);
                itens.Add(texto);
            }
            listaview_tabuada.ItemsSource = itens;
        }
    }
}
