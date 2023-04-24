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

namespace WpfApp2
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
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                
                double n = double.Parse(TbNumberN.Text);
                double m = double.Parse(TbNumberM.Text);
                string rezult = "";
                string rezult1 ="";
                switch (n)
                {
                    case 6:
                        rezult = "шестёрка" ;
                        break;
                    case 7:
                        rezult = "семёрка";
                        break;
                    case 8:
                        rezult = "восьмёрка";
                        break;
                    case 9:
                        rezult = "девятка";
                        break;
                    case 10:
                        rezult = "десятка";
                        break;
                    case 11:
                        rezult = "валет";
                        break;
                    case 12:
                        rezult = "дама";
                        break;
                    case 13:
                        rezult = "король";
                        break;
                    case 14:
                        rezult = "туз";
                        break;
                    default:
                        break;
                }
                
                switch (m)
                {

                    //1 — пики, 2 — трефы, 3 - бубны, 4 — червы.
                    case 1:
                        rezult1 = "пики";
                        break;
                    case 2:
                        rezult1 = "трефы";
                        break;
                    case 3:
                        rezult1 = "бубны";
                        break;
                    case 4:
                        rezult1 = "черви";
                        break;
                    default:
                        break;
                }
                TextBlockAnswer.Text = $"{rezult} {rezult1}";








            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
