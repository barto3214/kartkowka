using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kartkowka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float Z;
            if (float.TryParse(money.Text,out Z)) {
                if (euro.IsChecked == true) {
                    float eurokasa = Z*0.23f;
                    MessageBox.Show(Z.ToString() + "zł. To " + eurokasa.ToString() + " euro.");
                }
                if (franki.IsChecked == true)   
                {
                    float frankikasa = Z * 0.33f;
                    MessageBox.Show(Z.ToString() + "zł. To " + frankikasa.ToString() + " franków.");
                }
                if (dolary.IsChecked == true)
                {
                    float dolarykasa = Z * 0.43f;
                    MessageBox.Show(Z.ToString() + "zł. To " + dolarykasa.ToString() + " dolarów.");
                }
            }
            else
            {
                MessageBox.Show("Nie można wpisywać czegoś innego niż liczby");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double tep;
            double.TryParse(temp.Text, out tep);
            if ((bool)Cel.IsChecked) {

                if ((bool)Cel2.IsChecked) {
                    MessageBox.Show("Oto temperatura w Celsjuszach: " + tep.ToString());
                }
                if ((bool)Far2.IsChecked)
                {
                    MessageBox.Show("Oto temperatura w Farenheitach: " + ((tep * (9f/5)) + 32));
                }
                if ((bool)Kel2.IsChecked)
                {
                    MessageBox.Show("Oto temperatura w Kelvinach: " + (tep + 273.15));
                }

            }
            if ((bool)Far.IsChecked)
            {

                if ((bool)Cel2.IsChecked)
                {
                    MessageBox.Show("Oto temperatura w Celsjuszach: " + ((tep - 32) * (5f/9)));
                }
                if ((bool)Far2.IsChecked)
                {
                    MessageBox.Show("Oto temperatura w Farenheitach: " + tep.ToString());
                }
                if ((bool)Kel2.IsChecked)
                {
                    MessageBox.Show("Oto temperatura w Kelvinach: " + (((tep - 32) * (5f / 9)) + 273.15));
                }

            }
            if ((bool)Kel.IsChecked)
            {

                if ((bool)Cel2.IsChecked)
                {
                    MessageBox.Show("Oto temperatura w Celsjuszach: " + (tep - 273.15));
                }
                if ((bool)Far2.IsChecked)
                {
                    MessageBox.Show("Oto temperatura w Farenheitach: " + (((9f/5) * (tep - 273.15)) + 32));
                }
                if ((bool)Kel2.IsChecked)
                {
                    MessageBox.Show("Oto temperatura w Kelvinach: " + tep.ToString());
                }

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string decyzja = comboboks.Text;
            int bo3;
            int bo4;
            int.TryParse(bok.Text, out bo3);
            int.TryParse(bok2.Text, out bo4);
            switch (decyzja)
            {
                case "Trójkąt równoboczny":
                    if ((bool)pole.IsChecked) {
                        MessageBox.Show("Oto pole trójkąta: " + ((bo3 * bo4) / 2));
                    }
                    if ((bool)obwod.IsChecked) {
                        MessageBox.Show("Oto obwod trójkąta: " + (bo3 * 3));
                    }
                break;

                case "Kwadrat":
                    if ((bool)pole.IsChecked)
                    {
                        MessageBox.Show("Oto pole kwadratu: " + (Math.Pow(bo3,2)));
                    }                             
                    if ((bool)obwod.IsChecked)    
                    {                             
                        MessageBox.Show("Oto obwod kwadratu: " + (bo3 * 4));
                    }
                    break;

                case "Pięciokąt":
                    if ((bool)pole.IsChecked)
                    {
                        MessageBox.Show("Oto pole pięciokąta: " + ((1f/4) * Math.Sqrt(5 * (5+(2*Math.Sqrt(5)))) * (Math.Pow(bo3,2))));
                    }
                    if ((bool)obwod.IsChecked)
                    {
                        MessageBox.Show("Oto obwod pięciokąta: " + (bo3 * 5));
                    }
                    break;
            }
        }
    }
}