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

namespace WpfApp8
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
                switch (n/100)
                    {
                        case 1:
                            TextBlockAnswer.Text = $"Сто";
                            break;
                        case 2:
                            TextBlockAnswer.Text = $"Двести";
                            break;
                        case 3:
                            TextBlockAnswer.Text = $"Триста";
                            break;
                        case 4:
                            TextBlockAnswer.Text = $"Четыреста";
                            break;
                        case 5:
                            TextBlockAnswer.Text = $"Пятьсот";
                            break;
                        case 6:
                            TextBlockAnswer.Text = $"Шестьсот";
                            break;
                        case 7:
                            TextBlockAnswer.Text = $"Семьсот";
                            break;
                        case 8:
                            TextBlockAnswer.Text = $"Восемьсот";
                            break;
                        case 9:
                            TextBlockAnswer.Text = $"Девятьсот";
                            break;
                    }

                if((n%100)/10==1)
                
                    switch (n % 100)
                    {
                        case 10:
                            TextBlockAnswer.Text += $" десять ";
                            break;
                        case 11:
                            TextBlockAnswer.Text += $" одиннадцать ";
                            break;
                        case 12:
                            TextBlockAnswer.Text += $" двенадцать ";
                            break;
                        case 13:
                            TextBlockAnswer.Text += $" тринадцать ";
                            break;
                        case 14:
                            TextBlockAnswer.Text += $" четырнадцать ";
                            break;
                        case 15:
                            TextBlockAnswer.Text += $" пятнадцать ";
                            break;
                            case 16:
                            TextBlockAnswer.Text += $" шестнадцать ";
                            break;
                            case 17:
                            TextBlockAnswer.Text += $" семнадцать ";
                            break;
                            case 18:
                            TextBlockAnswer.Text += $" восемнадцать ";
                            break;
                            case 19:
                            TextBlockAnswer.Text += $" девятнадцать";
                            break;
                        
                    }
                    else {

                        switch ((n % 100) / 10)
                        {
                            case 2:
                                TextBlockAnswer.Text += $" двадцать ";
                                break;
                            case 3:
                                TextBlockAnswer.Text += $" тридцать ";
                                break;
                            case 4:
                                TextBlockAnswer.Text += $" сорок ";
                                break;
                            case 5:
                                TextBlockAnswer.Text += $" пятьдесят ";
                                break;
                            case 6:
                                TextBlockAnswer.Text += $" шестьдесят ";
                                break;
                            case 7:
                                TextBlockAnswer.Text += $" семьдесят ";
                                break;
                            case 8:
                                TextBlockAnswer.Text += $" восемьдесят ";
                                break;
                            case 9:
                                TextBlockAnswer.Text += $" девяносто ";
                                break;
                            
                        }
                    


                    switch (n % 10)
                    {
                        case 1:
                            TextBlockAnswer.Text += $"один";
                            break;
                        case 2:
                            TextBlockAnswer.Text += $"два";
                            break;
                        case 3:
                            TextBlockAnswer.Text += $"три";
                            break;
                        case 4:
                            TextBlockAnswer.Text += $"четыре";
                            break;
                        case 5:
                            TextBlockAnswer.Text += $"пять";
                            break;
                        case 6:
                            TextBlockAnswer.Text += $"шесть";
                            break;
                        case 7:
                            TextBlockAnswer.Text += $"семь";
                            break;
                        case 8:
                            TextBlockAnswer.Text += $"восемь";
                            break;
                        case 9:
                            TextBlockAnswer.Text += $"девять";
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
