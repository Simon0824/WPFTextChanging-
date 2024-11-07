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

namespace Edytor
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Aktualizuj(object sender, RoutedEventArgs e)
        {
            if (bold == null || italic == null || Podkresl == null || Czarnyczcionk == null || Czerwonyczcionk == null ||
                Zielonyczcionk == null || Niebieskiczcionk == null ||
                BezowyTlo == null || CzerwonyTlo == null || ZielonyTlo == null 
                || NiebieskiTlo == null || Lewo == null || Srodek == null || Prawo == null || Just == null || Arial == null ||
                Times == null || Courier == null)
            {
                return; 
            }
            UstawKolorCzcionki();
            UstawKolorTla();
            UstawJustowanie();
            UstawStylCzcionki();
            RozmCzionki();
            Progres();
        }

        private void UstawKolorCzcionki()
        {
            if (Czarnyczcionk.IsChecked == true)
            {
                poletekstu.Foreground = Brushes.Black;
            }
            if (Czerwonyczcionk.IsChecked == true)
            {
                poletekstu.Foreground = Brushes.Red;
            }
            if (Zielonyczcionk.IsChecked == true)
            {
                poletekstu.Foreground = Brushes.Green;
            }
            if (Niebieskiczcionk.IsChecked == true)
            {
                poletekstu.Foreground = Brushes.Blue;
            }
        }

        private void UstawKolorTla()
        {
            if (BezowyTlo.IsChecked == true)
            {
                poletekstu.Background = Brushes.DarkKhaki;
            }
            if (CzerwonyTlo.IsChecked == true)
            {
                poletekstu.Background = Brushes.Red;
            }
            if (ZielonyTlo.IsChecked == true)
            {
                poletekstu.Background = Brushes.Green;
            }
            if (NiebieskiTlo.IsChecked == true)
            {
                poletekstu.Background = Brushes.Blue;
            }
        }

        private void UstawJustowanie()
        {
            if(Lewo.IsChecked == true)
            poletekstu.TextAlignment = TextAlignment.Left;
            if(Srodek.IsChecked==true)
                poletekstu.TextAlignment= TextAlignment.Center;
            if (Prawo.IsChecked == true)
                poletekstu.TextAlignment = TextAlignment.Right;
            if (Just.IsChecked == true)
                poletekstu.TextAlignment = TextAlignment.Justify;
            
        }

        private void UstawStylCzcionki()
        {
            //Domyślny styl tesktu
            var styl = FontStyles.Normal;
            var grubosc = FontWeights.Normal;
            var dodatki = new TextDecorationCollection();

            if(bold.IsChecked == true)
                grubosc = FontWeights.Bold;
            if(italic.IsChecked == true)
                styl = FontStyles.Italic;
            if (Podkresl.IsChecked == true)
                dodatki = TextDecorations.Underline;
            poletekstu.FontStyle = styl;
            poletekstu.FontWeight = grubosc;
            poletekstu.TextDecorations = dodatki;
        }

        private void UstawKrojCzcionki()
        {
            if(Arial.IsChecked == true)
            poletekstu.FontFamily = Arial.FontFamily;
            if(Courier.IsChecked == true)
                poletekstu.FontFamily = Courier.FontFamily;
            if(Times.IsChecked == true)
                poletekstu.FontFamily = Times.FontFamily;
           
        }

        private void RozmCzionki()
        {

        }

        private void Progres()
        {
            int progresik = 0;

            if (bold.IsChecked == true) progresik++;
            if (italic.IsChecked == true) progresik++;
            if (Podkresl.IsChecked == true) progresik++;
            if(Czarnyczcionk.IsChecked == true || Czerwonyczcionk.IsChecked == true ||   Zielonyczcionk.IsChecked == true
                || Niebieskiczcionk.IsChecked == true) progresik++;
            if (BezowyTlo.IsChecked == true || CzerwonyTlo.IsChecked == true || ZielonyTlo.IsChecked == true || NiebieskiTlo.IsChecked == true) progresik++;
            if (Lewo.IsChecked == true || Srodek.IsChecked ==true || Prawo.IsChecked == true || Just.IsChecked == true) progresik++;
            if ()
        }
    }
}