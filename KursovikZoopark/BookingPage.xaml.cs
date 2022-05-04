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
    /// Логика взаимодействия для BookingPage.xaml
    /// </summary>
    public partial class BookingPage : Page
    {
        public BookingPage(Exkursion Ex)
        {
            InitializeComponent();
            dataPicker.DisplayDateStart = DateTime.Now;
            for (int i = 9; i < 20; i++)
            {
                HourComboBox.ItemsSource = i.ToString();
            }
        }

        private void BookingEx(object sender, RoutedEventArgs e)
        {

        }
    }
}
