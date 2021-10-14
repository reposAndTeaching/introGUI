using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace introGUI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //DRY => Dont repeat yourself
        List<Pelicula> listaPeliculas;
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Título desde código";
            listaPeliculas = new List<Pelicula>();
            listaPeliculas.Add(new Pelicula("Iron-Man", 2008, true));

            actualizarListado();
        }

        private void buttonRegistrar_Click(object sender, RoutedEventArgs e)
        {
            string nombreCaja = textBoxNombre.Text;
            int anioCaja = Convert.ToInt32(textBoxAnio.Text);
            var recomiendaCaja = checkBoxRecomienda.IsChecked;

            Pelicula p = new Pelicula(nombreCaja, anioCaja, (bool)recomiendaCaja);
            listaPeliculas.Add(p);

            actualizarListado();

            textBoxNombre.Text = "";
            textBoxAnio.Text = "";
            checkBoxRecomienda.IsChecked = false;

            textBoxNombre.Focus();
        }

        private void actualizarListado()
        {
            string textoLabel = "";
            foreach (Pelicula pelicula in listaPeliculas)
            {
                textoLabel += pelicula;
                textoLabel += "\n";
            }
            labelLista.Content = textoLabel;
        }


    }
}
