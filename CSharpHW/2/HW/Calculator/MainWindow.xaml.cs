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

        private void addValues()
        {
            double fop = double.Parse(tbFirstOperand.Text);
            double sop = double.Parse(tbSecondOperand.Text);
            double res = fop + sop;
            tbShowResult.Text = Math.Round(res, 2).ToString();
        }

        private void subtractValues()
        {
            double fop = double.Parse(tbFirstOperand.Text);
            double sop = double.Parse(tbSecondOperand.Text);
            double res = fop - sop;
            tbShowResult.Text = Math.Round(res, 2).ToString();
        }

        private void multiplyValues()
        {
            double fop = double.Parse(tbFirstOperand.Text);
            double sop = double.Parse(tbSecondOperand.Text);
            double res = fop * sop;
            tbShowResult.Text = Math.Round(res, 2).ToString();
        }

        private void divideValues()
        {
            double fop = double.Parse(tbFirstOperand.Text);
            double sop = double.Parse(tbSecondOperand.Text);
            double res = fop / sop;
            tbShowResult.Text = Math.Round(res, 2).ToString();
        }

        private void remainderValues()
        {
            double fop = double.Parse(tbFirstOperand.Text);
            double sop = double.Parse(tbSecondOperand.Text);
            double res = fop % sop;
            tbShowResult.Text = Math.Round(res, 2).ToString();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)addition.IsChecked)
                {
                    addValues();
                }
                else if ((bool)subtraction.IsChecked)
                {
                    subtractValues();
                }
                else if ((bool)multiplication.IsChecked)
                {
                    multiplyValues();
                }
                else if ((bool)division.IsChecked)
                {
                    divideValues();
                }
                else if ((bool)remainder.IsChecked)
                {
                    remainderValues();
                }
            }
            catch (Exception caught)
            {
                tbShowResult.Text = caught.Message;
            }
        }
    }
}
