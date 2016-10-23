using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ByteInfo();
            SByteInfo();
            IntInfo();
            UIntInfo();
            ShortInfo();
            UShortInfo();
            LongInfo();
            ULongInfo();
            FloatInfo();
            DoubleInfo();
            DecimalInfo();

            Console.ReadLine();
        }
        private static void ByteInfo()
        {
            Console.WriteLine("Byte:");
            Console.WriteLine("Max value: " + byte.MaxValue);
            Console.WriteLine("Min value: " + byte.MinValue);
            Console.WriteLine("Dejault value: " + default(byte)); Console.WriteLine();
        }

        private static void SByteInfo()
        {
            Console.WriteLine("sByte:");
            Console.WriteLine("Max value: " + sbyte.MaxValue);
            Console.WriteLine("Min value: " + sbyte.MinValue);
            Console.WriteLine("Dejault value: " + default(sbyte)); Console.WriteLine();
        }

        private static void IntInfo()
        {
            Console.WriteLine("Int:");
            Console.WriteLine("Max value: " + int.MaxValue);
            Console.WriteLine("Min value: " + int.MinValue);
            Console.WriteLine("Dejault value: " + default(int)); Console.WriteLine();
        }

        private static void UIntInfo()
        {
            Console.WriteLine("uInt:");
            Console.WriteLine("Max value: " + uint.MaxValue);
            Console.WriteLine("Min value: " + uint.MinValue);
            Console.WriteLine("Dejault value: " + default(uint)); Console.WriteLine();
        }

        private static void ShortInfo()
        {
            Console.WriteLine("Short:");
            Console.WriteLine("Max value: " + short.MaxValue);
            Console.WriteLine("Min value: " + short.MinValue);
            Console.WriteLine("Dejault value: " + default(short)); Console.WriteLine();
        }

        private static void UShortInfo()
        {
            Console.WriteLine("uShort:");
            Console.WriteLine("Max value: " + ushort.MaxValue);
            Console.WriteLine("Min value: " + ushort.MinValue);
            Console.WriteLine("Dejault value: " + default(ushort)); Console.WriteLine();
        }

        private static void LongInfo()
        {
            Console.WriteLine("Long:");
            Console.WriteLine("Max value: " + long.MaxValue);
            Console.WriteLine("Min value: " + long.MinValue);
            Console.WriteLine("Dejault value: " + default(long)); Console.WriteLine();
        }

        private static void ULongInfo()
        {
            Console.WriteLine("uLong:");
            Console.WriteLine("Max value: " + ulong.MaxValue);
            Console.WriteLine("Min value: " + ulong.MinValue);
            Console.WriteLine("Dejault value: " + default(ulong)); Console.WriteLine();
        }

        private static void FloatInfo()
        {
            Console.WriteLine("Float:");
            Console.WriteLine("Max value: " + float.MaxValue);
            Console.WriteLine("Min value: " + float.MinValue);
            Console.WriteLine("Dejault value: " + default(float)); Console.WriteLine();
        }

        private static void DoubleInfo()
        {
            Console.WriteLine("Double:");
            Console.WriteLine("Max value: " + double.MaxValue);
            Console.WriteLine("Min value: " + double.MinValue);
            Console.WriteLine("Dejault value: " + default(double)); Console.WriteLine();
        }

        private static void DecimalInfo()
        {
            Console.WriteLine("Decimal:");
            Console.WriteLine("Max value: " + decimal.MaxValue);
            Console.WriteLine("Min value: " + decimal.MinValue);
            Console.WriteLine("Dejault value: " + default(decimal));
        }
    }
}
