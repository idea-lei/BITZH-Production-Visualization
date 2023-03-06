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

namespace Lecture2_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // append number
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Textbox_Main.Text += (string)((Button)sender).Content;
        }

        // clear
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Textbox_Main.Text = string.Empty;
            Num_1.Content = string.Empty;
        }

        private string op;
        private double num1;
        private double num2;
        private void Button_Click_Operator(object sender, RoutedEventArgs e)
        {
            op = (string)((Button)sender).Content;
            double.TryParse(Textbox_Main.Text, out num1);

            Num_1.Content = $"{Textbox_Main.Text} {op}";

            Textbox_Main.Text = string.Empty;
        }

        // calculate
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double.TryParse(Textbox_Main.Text, out num2);

            double result;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            Textbox_Main.Text = result.ToString();
            Num_1.Content = string.Empty;
        }
    }
}
