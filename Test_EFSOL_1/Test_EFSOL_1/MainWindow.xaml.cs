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


namespace Test_EFSOL_1
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
        //   double num1, num2;

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text.Replace(".", ",");
           StatClass.num1 = Convert.ToDouble(TextBox1.Text);
            TextBox2.Text = TextBox2.Text.Replace(".", ",");
            StatClass.num2 = Convert.ToDouble(TextBox2.Text);
            StatClass.num1_integer = Math.Truncate(StatClass.num1);
            StatClass.num2_integer = Math.Truncate(StatClass.num2);
            StatClass.num1_fractional = Math.Round((StatClass.num1 - StatClass.num1_integer), (Convert.ToString(StatClass.num1).Length));
            StatClass.num2_fractional = Math.Round((StatClass.num2 - StatClass.num2_integer), (Convert.ToString(StatClass.num2).Length));
            Divide.Division(/*StatClass.num1, StatClass.num2*/);
            ResultLabel.Content = StatClass.result;           //   почему это работает так как надо???

           
            { }
        /*    int z = 0;
            for (int i = 0; i < Convert.ToString(num1).Length; i++)           //   подсчёт символов в "строке"
            {
                if (Convert.ToString(num1)[i] == ',')
                {
                    
                    z++;
                }
            }
            if (z != 0)
            {
                ResultLabel.Content = (Convert.ToString(num1)).Length -2 ;          //   если есть запятая в строке
            }
            else
            {
                ResultLabel.Content = (Convert.ToString(num1)).Length;          //   если есть запятая в строке
            }*/


    }
    }
}
