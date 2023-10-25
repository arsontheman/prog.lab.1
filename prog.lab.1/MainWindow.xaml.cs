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

namespace PolynomialCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double a1 = double.Parse(textBoxA1.Text);
            double b1 = double.Parse(textBoxB1.Text);
            double c1 = double.Parse(textBoxC1.Text);
            double d1 = double.Parse(textBoxD1.Text);

            double a2 = double.Parse(textBoxA2.Text);
            double b2 = double.Parse(textBoxB2.Text);
            double c2 = double.Parse(textBoxC2.Text);
            double d2 = double.Parse(textBoxD2.Text);

            Polynomial polynomial1 = new Polynomial(a1, b1, c1, d1);
            Polynomial polynomial2 = new Polynomial(a2, b2, c2, d2);

            Polynomial result = polynomial1.Add(polynomial2);

            resultTextBlock.Text = $"Результат: {result}";
        }
    }
}