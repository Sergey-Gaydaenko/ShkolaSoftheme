using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AgeAndZodiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime bDay = new DateTime();
            bDay = ValidateBDay(bDay);
            GetAge(bDay);
            GetZodiac(bDay);
            var zodiac = GetZodiac(bDay);
            Console.WriteLine("Your zodiac is: {0}", zodiac);

            Console.ReadLine();
        }
        private static DateTime ValidateBDay(DateTime birthDay)
        {
            Console.WriteLine("Pleae enter your birth day: ");
            birthDay = !DateTime.TryParse(Console.ReadLine(), out birthDay) ? ValidateBDay(birthDay) : birthDay;
            return birthDay;
        }

        private static void GetAge(DateTime BirthDay)
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDay.Year;
            if (BirthDay > today.AddYears(-age)) age--;

            Console.WriteLine("Your age is: {0}", age);
        }

        private static string GetZodiac(DateTime BirthDay)
        {
            int month = BirthDay.Month;
            int day = BirthDay.Day;
            switch (month)
            {
                case 1:
                    if (day <= 19)
                        return "Capricorn";
                    else
                        return "Aquarius";

                case 2:
                    if (day <= 18)
                        return "Aquarius";
                    else
                        return "Pisces";
                case 3:
                    if (day <= 20)
                        return "Pisces";
                    else
                        return "Aries";
                case 4:
                    if (day <= 19)
                        return "Aries";
                    else
                        return "Taurus";
                case 5:
                    if (day <= 20)
                        return "Taurus";
                    else
                        return "Gemini";
                case 6:
                    if (day <= 20)
                        return "Gemini";
                    else
                        return "Cancer";
                case 7:
                    if (day <= 22)
                        return "Cancer";
                    else
                        return "Leo";
                case 8:
                    if (day <= 22)
                        return "Leo";
                    else
                        return "Virgo";
                case 9:
                    if (day <= 22)
                        return "Virgo";
                    else
                        return "Libra";
                case 10:
                    if (day <= 22)
                        return "Libra";
                    else
                        return "Scorpio";
                case 11:
                    if (day <= 21)
                        return "Scorpio";
                    else
                        return "Sagittarius";
                case 12:
                    if (day <= 21)
                        return "Sagittarius";
                    else
                        return "Capricorn";
            }
            return null;
        }
    }
}
