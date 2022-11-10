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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Zhostki_Click(object sender, RoutedEventArgs e)
        {
            ShowResault("Жесткий");
        }

        private void Soft_Click(object sender, RoutedEventArgs e)
        {
            ShowResault("Мягкий");
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
                    if (MainWindowHelpers.transports[i].TransportType == "Автобус")
                    {
                        resault += $"Номер - {((Bus)MainWindowHelpers.transports[i]).TripNum}; {type} - {((Bus)MainWindowHelpers.transports[i])[type]}\n";
                    }
                }
                Resault.Content = resault;
            }
        }
    }
}
