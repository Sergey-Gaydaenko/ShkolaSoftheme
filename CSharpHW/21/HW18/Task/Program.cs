using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MobileOperator mobileOperator = new MobileOperator();
            var acc1 = mobileOperator.CreateAccount(0930575249);
            var acc2 = mobileOperator.CreateAccount(1234565656);
            var acc3 = mobileOperator.CreateAccount(12312312);
            var acc4 = mobileOperator.CreateAccount(23423423);
            var acc5 = mobileOperator.CreateAccount(234234234);
            var acc6 = mobileOperator.CreateAccount(234423432);
            var acc7 = mobileOperator.CreateAccount(234234);
            var acc8 = mobileOperator.CreateAccount(12312332);
            var acc9 = mobileOperator.CreateAccount(123123243);
            var acc10 = mobileOperator.CreateAccount(324234324);


            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                mobileOperator.BinarySerialize();
            }
            stopWatch.Stop();
            Console.WriteLine("Serialization type binary {0} ms", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                mobileOperator.BinaryDeserialize();
            }
            stopWatch.Stop();
            Console.WriteLine("Deserialization type binary {0} ms", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();


            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                mobileOperator.JsonSerialize();
            }
            stopWatch.Stop();
            Console.WriteLine("Serialization type JSON {0} ms", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                mobileOperator.JsonDeserialize();
            }
            stopWatch.Stop();

            Console.WriteLine("Deserialization type JSON {0} ms", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                mobileOperator.XmlSerialize();
            }
            stopWatch.Stop();
            Console.WriteLine("Serialization type XML {0} ms", stopWatch.ElapsedMilliseconds);

            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                mobileOperator.XmlDeserialize();
            }
            stopWatch.Stop();
            Console.WriteLine("Deserialization type XML {0} ms", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                mobileOperator.ProtobufSerialize();
            }
            stopWatch.Stop();

            Console.WriteLine("Serialization type Protobuf {0} ms", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                mobileOperator.ProtobufDeserialize();
            }

            stopWatch.Stop();
            Console.WriteLine("Deserialization type Protobuf {0} ms", stopWatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
