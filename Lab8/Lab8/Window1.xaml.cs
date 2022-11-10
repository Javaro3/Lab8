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

namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Econom_Click(object sender, RoutedEventArgs e)
        {
            ShowResault("Эконом");
        }

        private void Busness_Click(object sender, RoutedEventArgs e)
        {
            ShowResault("Бизнес");
        }

        private void Pervi_Click(object sender, RoutedEventArgs e)
        {
            ShowResault("Первый");
        }

        public void ShowResault(string type)
        {
            if (MainWindowHelpers.transports.Length == 0)
            {
                Resault.Content = "Ошибка";
            }
            else
            {
                string resault = "";
                for (int i = 0; i < MainWindowHelpers.transports.Length; i++)
                {
                    if (MainWindowHelpers.transports[i].TransportType == "Cамолет")
                    {
                        resault += $"Номер - {((Plain)MainWindowHelpers.transports[i]).TripNum}; {type} - {((Plain)MainWindowHelpers.transports[i])[type]}\n";
                    }
                }
                Resault.Content = resault;
            }
        }
    }
}
