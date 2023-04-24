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
using static System.Math;

namespace WpfApp3
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
                double x = double.Parse(TbNumberX.Text);
                double a, c, h, s;
                switch (n)
                {
                    case 1:
                        a = x;
                        c = a * Sqrt(2);
                        h = c / 2;
                        s = c * h / 2;
                        TextBlockAnswer.Text = $"c = {c},\n h = {h},\n s = {s}";
                        break;
                    case 2:
                        c = x;
                        a = c / Sqrt(2);
                        h = c / 2;
                        s = c * h / 2;
                        TextBlockAnswer.Text = $"a = {a},\n h= {h},\n s = {s}";
                        break;
                    case 3:
                        h = x;
                        c = 2 * h;
                        a = c / Sqrt(2);
                        s = c * h / 2;
                        TextBlockAnswer.Text = $"a = {a},\n c = {c},\n s = {s}";
                        break;
                    case 4:
                        s = x;
                        h = Sqrt(s);
                        c = 2 * h;
                        a = c / Sqrt(2);
                        TextBlockAnswer.Text = $"a = {a},\n c = {c},\n h = {h}";
                        break;
                    default:
                        break;
                }

               



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
