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

namespace KursovikZoopark
{
    /// <summary>
    /// Логика взаимодействия для BookingInfoPage.xaml
    /// </summary>
    public partial class BookingInfoPage : Page
    {
        private Exkursion selectEx;
        User _client;
        public BookingInfoPage(Exkursion Ex, User client)
        {
            InitializeComponent();
            _client = client;
            selectEx = Ex;
            nameExTaxtBlock.Text = Ex.name;
            priceTextBlock.Text = Ex.price.ToString();
            maxManTextBlock.Text = Ex.maxMan.ToString();
            durationTextBlock.Text = Ex.duration.ToString();
        }

        private void BookingEx(object sender, RoutedEventArgs e)
        {
            ClientWin MW = (ClientWin)Window.GetWindow(this);
            MW.MainFrame.Content = new BookingPage(selectEx, _client);
        }
    }
}
