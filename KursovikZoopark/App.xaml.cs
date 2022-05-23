using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KursovikZoopark
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static KursovikZooparkEntities3 Context;

        void Application_Start(object sender, StartupEventArgs args)
        {
            Context = new KursovikZooparkEntities3();
        }
    }
}
