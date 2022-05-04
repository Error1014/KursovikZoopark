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
        public ListExkursion()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var result = from E in App.Context.Exkursion.ToList()
                         select  E;
            //List<TableEx> Result = new List<TableEx>();
            //foreach (var item in result)
            //{
            //    TableEx TE = new TableEx(item.name,((float)item.price),item.duration.Value, item.maxMan.Value, item.isLike.Value, ((float)item.skidka));
            //}
            listEx.DataContext = result; 
        }
        public class TableEx
        {
            public TableEx()
            {

            }
            public TableEx(string name, float price, int duration, int maxMan, bool isLike, float skidka)
            {
                this.name = name;
                this.price = price;
                this.duration = duration;
                this.maxMan = maxMan;
                this.isLike  = isLike;
                this.skidka = skidka;
            }
            string name;
            float price;
            int duration;
            int maxMan;
            bool isLike;
            float skidka;
        }

        private void listEx_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var id = (listEx.SelectedItem as Exkursion).id;

            var selectEx = from E in App.Context.Exkursion.ToList()
                              where E.id == id
                              select E;
            Exkursion SelectEx = new Exkursion();
            foreach (var item in selectEx)
            {
                SelectEx = item;
            }
            MainWindow MW = (MainWindow)Window.GetWindow(this);
            MW.MainFrame.Content = new BookingInfoPage(SelectEx);
        }
    }
}
