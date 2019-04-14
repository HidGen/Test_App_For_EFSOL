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
               ResultLabel.Content = Multiplication.Multiplicate();

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
