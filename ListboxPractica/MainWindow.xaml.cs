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

namespace ListboxPractica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> Listapob = new List<Poblaciones>();

            Listapob.Add(new Poblaciones() { poblacion1 = "Madrid", poblacion2 = "Barcelona", temperatura1 = 15, temperatura2 = 28, DIferenciaTemp=13}); 
            Listapob.Add(new Poblaciones() { poblacion1 = "Valencia", poblacion2 = "Ucrania", temperatura1 = 16, temperatura2 = 27,  DIferenciaTemp = 11 }); 
            Listapob.Add(new Poblaciones() { poblacion1 = "Espana", poblacion2 = "BiliBili", temperatura1 = 17, temperatura2 = 29,  DIferenciaTemp = 12 }); 
            Listapob.Add(new Poblaciones() { poblacion1 = "Rusia", poblacion2 = "En ninguna parte", temperatura1 = 18, temperatura2 = 30,  DIferenciaTemp = 12 });
            //Indica de donde viene los items, en este caso es de lista pob
            listaPoblaciones.ItemsSource = Listapob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Dice que si selecciono un item de tipo poblacion o como tipo polacion se le indica la poblacion1 y asi sucesivamente con espacion
            if (listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).temperatura1 + "C " + (listaPoblaciones.SelectedItem as Poblaciones).poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).temperatura2 + "C");
            }
            else
            {
                MessageBox.Show("no se ha seleccionado ningun elemento");
            }
        }
        //Desencadena la accion al dar clic
        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).temperatura1 + "C " + (listaPoblaciones.SelectedItem as Poblaciones).poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).temperatura2 + "C");
            }
            
        }
    }
    public class Poblaciones
    {
        public string poblacion1 { get; set; }

        public int temperatura1 { get; set; }   
        
        public string poblacion2 { get; set; }

        public int temperatura2 { get; set; }

        public int DIferenciaTemp { get; set; }
    }

}
