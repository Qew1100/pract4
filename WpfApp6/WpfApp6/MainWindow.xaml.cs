﻿using System;
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

namespace WpfApp6
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
                int b;
                bool one = false;
                bool two = true;
                while (n > 0)
                {
                    b = n % 10;
                    n /= 10;
                    if (b % 2 == 1)
                    {
                        one = true;
                    }
                    else if (b % 2 == 0)
                    {
                        two = false;
                    }
                }
                if (one == true)
                {
                    TextBlockAnswer.Text=($"{one}");
                }
                else if (two == false)
                {
                    TextBlockAnswer.Text = ($"{two}");
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
