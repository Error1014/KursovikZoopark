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
    /// Логика взаимодействия для ListExkursion.xaml
    /// </summary>
    public partial class ListExkursion : Page
    {
        User _client;
        public ListExkursion(User client)
        {
            InitializeComponent();
            _client = client;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var result = from E in App.Context.Exkursion.ToList()
                         select  E;
            listEx.DataContext = result; 
        }

        private void SelectEx(object sender, MouseButtonEventArgs e)
        {
            Exkursion SelectEx = (listEx.SelectedItem as Exkursion);
            ClientWin CW = (ClientWin)Window.GetWindow(this);
            CW.MainFrame.Content = new BookingInfoPage(SelectEx, _client);
        }
    }
}
