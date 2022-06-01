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
    /// Логика взаимодействия для ZapisEdit.xaml
    /// </summary>
    public partial class ZapisEdit : Page
    {
        Booking selectBooking;
        public ZapisEdit(Booking booking)
        {
            InitializeComponent();
            selectBooking = booking;
            var client = from u in App.Context.User.ToList()
                         where u.id == selectBooking.idUser
                         select u;
            User user = new User();
            user = client.Max(x=>x);
            FIOTextBlock.Text = user.familia+" "+user.name;
            var ex = from e in App.Context.Exkursion.ToList()
                         where e.id == selectBooking.idExkursion
                         select e;
            Exkursion exkurs = new Exkursion();
            exkurs = ex.Max(x => x);
            ExkursTextBlock.Text = exkurs.name;
            valueMaxTextBlock.Text = selectBooking.valueMan.ToString();
            DateTimeTextBlock.Text = selectBooking.dateTime.ToString();
            double itog = selectBooking.itog.Value;
            MessageBox.Show(itog.ToString());
            itog = Math.Round(itog, 2);
            MessageBox.Show(itog.ToString());
            ItogTextBlock.Text = itog.ToString()+" руб.";
        }

        private void BuyExkurs(object sender, RoutedEventArgs e)
        {
            selectBooking.isEnd = true;
            App.Context.SaveChanges();
            AdminWin CW = (AdminWin)Window.GetWindow(this);
            CW.MainFrame.Content = new BookingList();
        }

    }
}
