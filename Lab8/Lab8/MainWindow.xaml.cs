using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Lab8
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

        private void Path_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(Path.Text))
            {
                if (Path.Text.Split('.')[Path.Text.Split('.').Length - 1] != "txt")
                {
                    label1.Content = "Файл должен быть с расширением .txt";
                }
                else
                {
                    label1.Content = "Введите путь к файлу";
                    string textFromFile;
                    using (FileStream fstream = File.OpenRead(Path.Text))
                    {
                        byte[] buffer = new byte[fstream.Length];
                        fstream.Read(buffer, 0, buffer.Length);
                        textFromFile = Encoding.Default.GetString(buffer);
                    }

                    string[] textArr = textFromFile.Split('\n');
                    string[] resault = new string[3] {"", "", ""};
                    MainWindowHelpers.transports = new Transport[textArr.Length];
                    for(int i = 0; i < textArr.Length; i++)
                    {
                        string[] trans = textArr[i].Split(' ');
                        if (trans[0] == "самолет")
                        {
                            MainWindowHelpers.transports[i] = new Plain("Cамолет", trans[2], trans[3], Convert.ToInt32(trans[1]),
                                new int[3] { Convert.ToInt32(trans[4]), Convert.ToInt32(trans[5]), Convert.ToInt32(trans[6]) });
                            resault[0] += ((Plain)MainWindowHelpers.transports[i]).ShowInfo() + "\n";
                        }
                        else if(trans[0] == "поезд")
                        {
                            MainWindowHelpers.transports[i] = new Train("Поезд", trans[2], trans[3], Convert.ToInt32(trans[1]),
                                new int[4] { Convert.ToInt32(trans[4]), Convert.ToInt32(trans[5]), Convert.ToInt32(trans[6]),
                                Convert.ToInt32(trans[7]) });
                            resault[1] += ((Train)MainWindowHelpers.transports[i]).ShowInfo() + "\n";
                        }
                        else if (trans[0] == "автобус")
                        {
                            MainWindowHelpers.transports[i] = new Bus("Автобус", trans[2], trans[3], Convert.ToInt32(trans[1]),
                                new int[2] { Convert.ToInt32(trans[4]), Convert.ToInt32(trans[5])});
                            resault[2] += ((Bus)MainWindowHelpers.transports[i]).ShowInfo() + "\n";
                        }
                    }
                    Plain.Foreground = Brushes.Red;
                    Train.Foreground = Brushes.Blue;
                    Plain.Content = resault[0];
                    Train.Content = resault[1];
                    Bus.Content = resault[2];
                }
            }
            else
            {
                label1.Content = "Такого файла нет";
            }
        }

        private void PlainBtn_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void BusBtn_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void TrainBtn_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }
    }
}
