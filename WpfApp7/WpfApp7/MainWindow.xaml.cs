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

namespace WpfApp7
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
                if (n / 10 == 1)
                
                    switch (n)
                    {
                        case 10:
                            TextBlockAnswer.Text = $"Десять заданий";
                            break;
                        case 11:
                            TextBlockAnswer.Text = $"Одинадцать заданий";
                            break;
                        case 12:
                            TextBlockAnswer.Text = $"Двенадцать заданий";
                            break;
                        case 13:
                            TextBlockAnswer.Text = $"Тринадцать заданий";
                            break;
                        case 14:
                            TextBlockAnswer.Text = $"Четырнадцать заданий";
                            break;
                        case 15:
                            TextBlockAnswer.Text = $"Пятнадцать заданий";
                            break;
                        case 16:
                            TextBlockAnswer.Text = $"Шестнадцать заданий";
                            break;
                        case 17:
                            TextBlockAnswer.Text = $"Семнадцать заданий";
                            break;
                        case 18:
                            TextBlockAnswer.Text = $"Восемнадцать заданий";
                            break;
                        case 19:
                            TextBlockAnswer.Text = $"Девятнадцать заданий";
                            break;
                    }
                
                else
                {
                    switch (n / 10)
                    {
                        case 2:
                            TextBlockAnswer.Text = $"Двадцать ";
                            break;
                        case 3:
                            TextBlockAnswer.Text = $"Тридцать ";
                            break;
                        case 4:
                            TextBlockAnswer.Text = $"Сорок ";
                            break;
                    }

                    switch (n % 10)
                    {
                        case 1:
                            TextBlockAnswer.Text += $"Одно ";
                            break;
                        case 2:
                            TextBlockAnswer.Text += $"Два ";
                            break;
                        case 3:
                            TextBlockAnswer.Text += $"Три ";
                            break;
                        case 4:
                            TextBlockAnswer.Text += $"Четыре ";
                            break;
                        case 5:
                            TextBlockAnswer.Text += $"Пять ";
                            break;
                        case 6:
                            TextBlockAnswer.Text += $"Шесть ";
                            break;
                        case 7:
                            TextBlockAnswer.Text += $"Семь ";
                            break;
                        case 8:
                            TextBlockAnswer.Text += $"Восемь ";
                            break;
                        case 9:
                            TextBlockAnswer.Text += $"Девять ";
                            break;
                    }


                    switch (n % 10)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            TextBlockAnswer.Text += $"учебных задач";
                            break;
                        case 1:
                            TextBlockAnswer.Text += $"учебное задание";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            TextBlockAnswer.Text += $"учебных задания";
                            break;
                    }
                }
                
                return;
            

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
