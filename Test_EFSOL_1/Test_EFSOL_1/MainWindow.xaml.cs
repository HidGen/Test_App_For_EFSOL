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
            StatClass.number1 = null;
            StatClass.number2 = null;
            StatClass.result = null;

            StatClass.summ = 0;

            StatClass.num1 = 0;
            StatClass.num2 = 0;
            StatClass.numba1 = 0;

            StatClass.num1_integer = 0;
            StatClass.num1_fractional = 0;
            StatClass.num2_integer = 0;
            StatClass.num2_fractional = 0;

            StatClass.num1_integer_s = null;
            StatClass.num1_fractional_s = null;
            StatClass.num2_integer_s = null;
            StatClass.num2_fractional_s = null;
            StatClass.num1_fractional_l = 0;
            StatClass.num2_fractional_l = 0;

            StatClass.fractional_l = 0;

            StatClass.num1_fractional_L = null;
            StatClass.reg = 0;


            if (Combobox1.Text == "÷")
            {
                StatClass.number1 = TextBox1.Text;
                StatClass.numba1 = Convert.ToDouble(TextBox1.Text);
                StatClass.number2 = TextBox2.Text;
                Divide.DivisionNumbers(/*StatClass.num1, StatClass.num2*/);
                ResultLabel.Content = StatClass.result;
            }
            else if (Combobox1.Text == "*")
            {
                TextBox1.Text = TextBox1.Text.Replace(".", ",");
                TextBox2.Text = TextBox2.Text.Replace(".", ",");
                StatClass.num1 = Convert.ToDouble(TextBox1.Text);
                StatClass.num2 = Convert.ToDouble(TextBox2.Text);
                Multiplication.Multiplicate();
                ResultLabel.Content = StatClass.result;
            }
            else if (Combobox1.Text == "+")
            {
                TextBox1.Text = TextBox1.Text.Replace(".", ",");
                TextBox2.Text = TextBox2.Text.Replace(".", ",");
                StatClass.num1 = Convert.ToDouble(TextBox1.Text);
                StatClass.num2 = Convert.ToDouble(TextBox2.Text);
                Addition.Add();
                ResultLabel.Content = StatClass.result;

            }
            else if (Combobox1.Text == "-")
            {
                TextBox1.Text = TextBox1.Text.Replace(".", ",");
                TextBox2.Text = TextBox2.Text.Replace(".", ",");
                StatClass.num1 = Convert.ToDouble(TextBox1.Text);
                StatClass.num2 = Convert.ToDouble(TextBox2.Text);
                Subtraction.Substract();
                ResultLabel.Content = StatClass.result;
            }
            else
            {
                MessageBox.Show("Не выбранно действие!");
                return;
            }



        }
    }
}
