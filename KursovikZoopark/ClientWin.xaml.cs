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
        public ClientWin()
        {
            InitializeComponent();
            MainFrame.Content = new ListExkursion();
        }
        private void NavListExkursion(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ListExkursion();
        }
        private void NavHistory(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MyHistory();
        }
    }
}
