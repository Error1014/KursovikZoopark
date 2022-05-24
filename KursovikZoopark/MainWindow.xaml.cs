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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Whod(object sender, RoutedEventArgs e)
        {
            foreach (var item in App.Context.User.ToList())
            {
                if (loginBox.Text == item.login)
                {
                    if (PassBox.Password==item.password)
                    {
                        if (item.role==1)
                        {
                            ClientWin CW = new ClientWin(item);
                            this.Close();
                            CW.Show();
                        }
                        else if(item.role == 2)
                        {
                            AdminWin AW = new AdminWin();
                            this.Close();
                            AW.Show();
                        }
                        break;
                    }
                }
            }
        }
    }
}
