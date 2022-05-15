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
    /// Логика взаимодействия для BookingList.xaml
    /// </summary>
    public partial class BookingList : Page
    {
        public BookingList()
        {
            InitializeComponent();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var result = from E in App.Context.Exkursion.ToList()
                         join B in App.Context.Booking on E.id equals B.idExkursion
                         join U in App.Context.User on B.idUser equals U.id
                         select new { U.familia,E.name, B.itog, B.valueMan, B.dateTime };
            listEx.DataContext = result;
        }

        private void SelectZapis(object sender, MouseButtonEventArgs e)
        {
            Exkursion SelectEx = (listEx.SelectedItem as Exkursion);
            ClientWin CW = (ClientWin)Window.GetWindow(this);
            CW.MainFrame.Content = new ZapisEdit(SelectEx);
        }
    }
}
