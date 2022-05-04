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
    /// Логика взаимодействия для BookingPage.xaml
    /// </summary>
    public partial class BookingPage : Page
    {
        private Exkursion selectEx;
        private float itog = 0;
        public BookingPage(Exkursion Ex)
        {
            InitializeComponent();
            selectEx = Ex;
            dataPicker.DisplayDateStart = DateTime.Now;
            for (int i = 1; i < Ex.maxMan + 1; i++)
            {
               ValueManComboBox.Items.Add(i);
            }
            for (int i = 9; i < 20 + 1; i++)
            {
                HourComboBox.Items.Add(i);
            }
            for (int i = 0; i < 50 + 1; i += 10)
            {
                MinutComboBox.Items.Add(i);
            }
        }

        private void BookingEx(object sender, RoutedEventArgs e)
        {

        }

        private void ValueManComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double price = (from E in App.Context.Exkursion.ToList()
                            where E.id == selectEx.id
                            select E.price).Max(x => x.Value);
            double sale = (from E in App.Context.Exkursion.ToList()
                           where E.id == selectEx.id
                           select E.skidka).Max(x => x.Value);
            sale /= 100;
            itog = (float)(price * int.Parse(ValueManComboBox.SelectedValue.ToString()));
            itog = (float)(itog - itog * sale);
            ItogTextBlock.Text = itog.ToString();
        }
    }
}
