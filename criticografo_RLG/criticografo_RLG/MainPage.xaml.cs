using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace criticografo_RLG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void criticar_Clicked(object sender, EventArgs e)
        {
            string nombre = entryName.Text;
            string genero = hombre.IsChecked? "hombre" :"mujer";

            string caracteristicas = obtenerCaracteristicas();
            string critica;
            if (hombre.IsChecked) {
                 critica = $"{nombre} su genero es {genero}, el es {caracteristicas}";
            }
            else if(mujer.IsChecked){
                critica = $"{nombre} su genero es {genero}, ella es {caracteristicas}";
            }
            else
            {
                critica = "su genero desconocido";
            }
            cuadro.Text = critica;
        }

        private string obtenerCaracteristicas()
        {
            var caracteristicasSeleccionadas = new System.Collections.Generic.List<string>();
            if (hombre.IsChecked == true) {
                if (Feo.IsChecked) { caracteristicasSeleccionadas.Add("feo"); }
                if (Hermoso.IsChecked) { caracteristicasSeleccionadas.Add("hermoso"); }
                if (alto.IsChecked) { caracteristicasSeleccionadas.Add("alto"); }
                if (bajo.IsChecked) { caracteristicasSeleccionadas.Add("bajo"); }
                if (listo.IsChecked) { caracteristicasSeleccionadas.Add("listo"); }
                if (tonto.IsChecked) { caracteristicasSeleccionadas.Add("tonto"); }
            }
            else
            {
                if (Feo.IsChecked) { caracteristicasSeleccionadas.Add("fea"); }
                if (Hermoso.IsChecked) { caracteristicasSeleccionadas.Add("hermosa"); }
                if (alto.IsChecked) { caracteristicasSeleccionadas.Add("alta"); }
                if (bajo.IsChecked) { caracteristicasSeleccionadas.Add("baja"); }
                if (listo.IsChecked) { caracteristicasSeleccionadas.Add("lista"); }
                if (tonto.IsChecked) { caracteristicasSeleccionadas.Add("tonta"); }
            }

            if (caracteristicasSeleccionadas.Count > 1)
            {
                int lastIndex = caracteristicasSeleccionadas.Count - 1;
                caracteristicasSeleccionadas[lastIndex] = "y " + caracteristicasSeleccionadas[lastIndex];
            }

            return string.Join(", ", caracteristicasSeleccionadas);
        }
    }
}
