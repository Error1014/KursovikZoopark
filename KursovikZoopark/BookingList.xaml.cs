﻿using System;
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
            var result = from B in App.Context.Booking.ToList()
                         from E in App.Context.Exkursion.ToList()
                         where B.idExkursion == E.id
                         select new { E.name, B.itog, B.valueMan, B.dateTime };
            listEx.DataContext = result;
        }
    }
}
