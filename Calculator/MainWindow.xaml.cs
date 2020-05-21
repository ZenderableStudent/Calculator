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

namespace Calculator
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Int32.Parse(txbFirstNumber.Text);
            int secondNumber = Int32.Parse(txbSecondNumber.Text);
            sumAll.Content = firstNumber + " + " + secondNumber + " = " + (firstNumber+secondNumber);
            subAll.Content = firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber);
            multiplyAll.Content = firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber);
            if(secondNumber == 0)
            {
                divideAll.Content = "Can't do it";
            }
            else
            {
                divideAll.Content = firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber);
            }
        }
    }
}
