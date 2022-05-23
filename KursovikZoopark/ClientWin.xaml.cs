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
    /// Логика взаимодействия для ClientWin.xaml
    /// </summary>
    public partial class ClientWin : Window
    {
        User _client;
        public ClientWin(User client)
        {
            InitializeComponent();
            _client = client;
            MainFrame.Content = new ListExkursion(_client);
        }
        private void NavListExkursion(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ListExkursion(_client);
        }
        private void NavHistory(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MyHistory(_client);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Close();
            MW.Show();
        }
    }
}
