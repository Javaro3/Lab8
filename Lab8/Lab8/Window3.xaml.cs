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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Luxe_Click(object sender, RoutedEventArgs e)
        {
            ShowResault("Люкс");
        }

        private void Kyp_Click(object sender, RoutedEventArgs e)
        {
            ShowResault("Купейный");
        }

        private void Plac_Click(object sender, RoutedEventArgs e)
        {
            ShowResault("Плацкартный");
        }

        private void Obz_Click(object sender, RoutedEventArgs e)
        {
            ShowResault("Общий");
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
                    if (MainWindowHelpers.transports[i].TransportType == "Поезд")
                    {
                        resault += $"Номер - {((Train)MainWindowHelpers.transports[i]).TripNum}; {type} - {((Train)MainWindowHelpers.transports[i])[type]}\n";
                    }
                }
                Resault.Content = resault;
            }
        }
    }
}
