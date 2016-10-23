using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace HW4
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

        private void btnEndRegistration_Click(object sender, RoutedEventArgs e)
        {
            Regex namePattern = new Regex(@"^[a-zA-Z]+$");
            Regex numberPattern = new Regex(@"^[0-9]+$");

            if (!Regex.IsMatch(tbFName.Text, namePattern.ToString(), RegexOptions.IgnoreCase) ||
                tbFName.Text.Length > 255)
            {
                MessageBox.Show("Invalid Data for first name");}

            else if (!Regex.IsMatch(tbLName.Text, namePattern.ToString(), RegexOptions.IgnoreCase) ||
                tbLName.Text.Length > 255)
            {
                MessageBox.Show("Invalid Data for last name");}
            
            else if (!Regex.IsMatch(tbDay.Text, numberPattern.ToString()) || 
                (!Regex.IsMatch(tbMounth.Text, numberPattern.ToString())) ||
                (!Regex.IsMatch(tbYear.Text, numberPattern.ToString()))
                
                ||((int.Parse(tbDay.Text) < 1 || int.Parse(tbDay.Text) > 31) ||
                (int.Parse(tbMounth.Text) < 1 || int.Parse(tbMounth.Text) > 12)||
                (int.Parse(tbYear.Text) <=1900 || int.Parse(tbYear.Text) > DateTime.Now.Year)))
            {
                MessageBox.Show("Invalid data for Birth day");
            }

            else if (tbGender.Text != "Male" && tbGender.Text != "Female")
            {
                MessageBox.Show("Gender should be `Male` or `Female`");}

            else if (!Regex.IsMatch(tbPhone.Text, numberPattern.ToString()) ||
                tbPhone.Text.Length !=12)
            {
                MessageBox.Show("Invalid Data for phone number");}

            else if (tbEmail.Text.IndexOf("@") == -1 || tbEmail.Text.Length > 255)
            {
                MessageBox.Show("Invalid data for Emeil");}

            else if (tbAdditionInfo.Text.Length > 2000)
            {
                MessageBox.Show("Addition lengh must be less then 2000 symbols");
            }

            else
            {
                MessageBox.Show("Registration successful!");}
        }
    }
}
