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

namespace WpfApp1
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
               
                int n = int.Parse(TbNumberN.Text);
                double a = double.Parse(TbNumberA.Text);
                double b = double.Parse(TbNumberB.Text);
                double rezult = 0;
                switch (n)
                {
                    case 1:
                        rezult = a + b;
                        break;
                    case 2:
                        rezult = a - b;
                        break;
                    case 3:
                        rezult = a * b;
                        break;
                    case 4:
                        rezult = a / b;
                        break;
                    default:
                        break;
                }
                TextBlockAnswer.Text = $"{rezult}";
                







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
