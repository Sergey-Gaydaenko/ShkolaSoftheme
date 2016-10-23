using System;
using System.Windows;


namespace magic_numbers
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static int GetNumber()
        {
            Random rand = new Random();
            int magicNumber = rand.Next(1, 10);
            return magicNumber;
        }

        private void btnMagic_Click(object sender, RoutedEventArgs e)
        {
            int userNumber;
            int magicNumber;
            try
            {
                userNumber = int.Parse(tbNumber.Text);
                magicNumber = GetNumber();

                tbMagicNumber.Text = magicNumber.ToString();
                if (userNumber == magicNumber)
                {
                    MessageBox.Show("Congratulations! ");
                }
                else
                {
                    MessageBox.Show("Magic number is " + magicNumber + ". Try again");
                }
                tbMagicNumber.Text = "*****";
            }
            catch (FormatException)
            {
                MessageBox.Show("Inalid input number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("your exeption is " + ex);
            }

        }
    }
}
