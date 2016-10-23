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

namespace ZodiacPicture
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

        private DateTime ValidateBDay(DateTime birthDay)
        {
            
            if(!DateTime.TryParse(tbBDay.Text, out birthDay))
            {
                MessageBox.Show("Invalid format of Date");
            }
           
            return birthDay;
        }

        public void GetAge(DateTime BirthDay)
        {
            try
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDay.Year;
                if (BirthDay > today.AddYears(-age)) age--;

                tbAge.Text = age.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data");
            }
        }

        public string GetZodiac(DateTime BirthDay)
        {
            int month = BirthDay.Month;
            int day = BirthDay.Day;
            switch (month)
            {
                case 1:
                    if (day <= 19)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Capricorn.png", UriKind.Relative));
                        return "Capricorn";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Aquarius.png", UriKind.Relative));
                        return "Aquarius";
                    }
                        

                case 2:
                    if (day <= 18)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Aquarius.png", UriKind.Relative));
                        return "Aquarius";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Pisces.png", UriKind.Relative));
                        return "Pisces";
                    }
                        
                case 3:
                    if (day <= 20)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Pisces.png", UriKind.Relative));
                        return "Pisces";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Aries.png", UriKind.Relative));
                        return "Aries";
                    }
                case 4:
                    if (day <= 19)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Aries.png", UriKind.Relative));
                        return "Aries";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Taurus.png", UriKind.Relative));
                        return "Taurus";
                    }
                case 5:
                    if (day <= 20)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Taurus.png", UriKind.Relative));
                        return "Taurus";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Gemini.png", UriKind.Relative));
                        return "Gemini";
                    }
                case 6:
                    if (day <= 20)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Gemini.png", UriKind.Relative));
                        return "Gemini";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Cancer.png", UriKind.Relative));
                        return "Cancer";
                    }
                case 7:
                    if (day <= 22)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Cancer.png", UriKind.Relative));
                        return "Cancer";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Leo.png", UriKind.Relative));
                        return "Leo";
                    }
                case 8:
                    if (day <= 22)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Leo.png", UriKind.Relative));
                        return "Leo";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Virgo.png", UriKind.Relative));
                        return "Virgo";
                    }
                case 9:
                    if (day <= 22)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Virgo.png", UriKind.Relative));
                        return "Virgo";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Libra.png", UriKind.Relative));
                        return "Libra";
                    }
                case 10:
                    if (day <= 22)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Libra.png", UriKind.Relative));
                        return "Libra";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Scorpio.png", UriKind.Relative));
                        return "Scorpio";
                    }
                case 11:
                    if (day <= 21)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Scorpio.png", UriKind.Relative));
                        return "Scorpio";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Sagittarius.png", UriKind.Relative));
                        return "Sagittarius";
                    }
                case 12:
                    if (day <= 21)
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Sagittarius.png", UriKind.Relative));
                        return "Sagittarius";
                    }
                    else
                    {
                        ZodiacImg.Source = new BitmapImage(new Uri(@"/Images/Capricorn.png", UriKind.Relative));
                        return "Capricorn";
                    }
            }
            return null;
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            var bDay = new DateTime();
            bDay = ValidateBDay(bDay);

            GetAge(bDay);
            tbZodiac.Text = GetZodiac(bDay);


        }
    }
}
