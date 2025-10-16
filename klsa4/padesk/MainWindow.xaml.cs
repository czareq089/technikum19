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

namespace Sklep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        
        int index = 0;
        Koszyk koszyk = new Koszyk();

        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += DodajProdukt;
            Dane.Text = koszyk.Produkty.ElementAt(0).Nazwa;
            Cena.Text = koszyk.Produkty.ElementAt(0).Cena.ToString();
            
        }

        public void DodajProdukt(Object s, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Window window = new Okienko();
                window.Show();
            }
        }

        private void bNext_Click(object sender, RoutedEventArgs e)
        {
            if (index < koszyk.Produkty.Count() - 1)
            {
                index++;
                Dane.Text = koszyk.Produkty.ElementAt(index).Nazwa;
                Cena.Text = koszyk.Produkty.ElementAt(index).Cena.ToString();
            }
        }

        private void bPrev_Click(object sender, RoutedEventArgs e)
        {
            if (index > 0)
            {
                index--;
                Dane.Text = koszyk.Produkty.ElementAt(index).Nazwa;
                Cena.Text = koszyk.Produkty.ElementAt(index).Cena.ToString();
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            int w = koszyk.obliczWartośćKoszyka();
            Cena_Przed.Content = $"Przed: {koszyk.obliczWartośćKoszyka()}";

            if(Int32.TryParse(Rabat.Text, out int r))
            {
                if(Rabat.Text.Trim() != "")
                {
                    int x = int.Parse(Rabat.Text);
                    if (procent.IsChecked == true)
                    {
                        ZniżkaProcentowa zniżka = new ZniżkaProcentowa();
                        Cena_Po.Content = $"Po: {zniżka.obliczZniżkę(w, x)}";

                    }
                    if (stala.IsChecked == true)
                    {
                        ZniżkaKwotowa zniżka = new ZniżkaKwotowa();
                        Cena_Po.Content = $"Po: {zniżka.obliczZniżkę(w, x)}";
                    }
                }

                else
                {
                    Cena_Po.Content = $"Po: {koszyk.obliczWartośćKoszyka()}";
                    MessageBox.Show("Rabat nie został podany");
                }
            }
        }
    }
}