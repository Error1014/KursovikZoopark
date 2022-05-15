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
using System.Windows.Shapes;

namespace KursovikZoopark
{
    /// <summary>
    /// Логика взаимодействия для AdminWin.xaml
    /// </summary>
    public partial class AdminWin : Window
    {
        public AdminWin()
        {
            InitializeComponent();
            MainFrame.Content = new BookingList();
        }

        private void NavBookingPageAdmin(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new BookingList();
        }

        private void NavHistoryPageAdmin(object sender, RoutedEventArgs e)
        {

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Close();
            MW.Show();
        }
    }
}
