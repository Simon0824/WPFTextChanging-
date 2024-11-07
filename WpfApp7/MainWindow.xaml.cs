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
                || NiebieskiTlo == null || Lewo == null || Srodek == null || Prawo == null || Arial == null ||
                Times == null || Courier == null)
            {
                return; 
            }
            UstawKolorCzcionki();
            UstawKolorTla();
            UstawJustowanie();
            UstawKrojCzcionki();
            RozmCzionki();
            Progres();
        }

        private void UstawKolorCzcionki()
        {

        }

        private void UstawKolorTla()
        {

        }

        private void UstawJustowanie()
        {

        }

        private void UstawKrojCzcionki()
        {

        }

        private void RozmCzionki()
        {

        }

        private void Progres()
        {

        }
    }
}