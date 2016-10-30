using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string filePath = "";
            try
            {
                filePath = Console.ReadLine();
            }
            catch (Exception)
            {
                
                Console.WriteLine("Error!");
            }

            var fileHendle = OpenFile(filePath, (FileAccessEnum)3);

            Console.WriteLine("Open for ReadWrite!");
            Console.WriteLine(fileHendle);

            Console.WriteLine("\nOpen for Read!");
            fileHendle = OpenForRead(filePath);
            Console.WriteLine(fileHendle);

            Console.WriteLine("\nOpen for Write!");
            fileHendle = OpenForWrite(filePath);
            Console.WriteLine(fileHendle);

            Console.ReadLine();
        }

        public static FileHandle OpenForRead(string filePath)
        {
            var fileInfo = new FileInfo(filePath);
            try
            {
                var fileHandle = new FileHandle(fileInfo.DirectoryName,
                                                fileInfo.Length,
                                                fileInfo.Name,
                                                FileAccessEnum.Read);
                return fileHandle;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            return default(FileHandle);
        }
        public static FileHandle OpenForWrite(string filePath)
        {
            var fileInfo = new FileInfo(filePath);
            try
            {
                var fileHandle = new FileHandle(fileInfo.DirectoryName,
                                                fileInfo.Length,
                                                fileInfo.Name,
                                                FileAccessEnum.Write);
                return fileHandle;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            return default(FileHandle);
        }
        public static FileHandle OpenFile(string filePath, FileAccessEnum accessStatus)
        {
            var fileInfo = new FileInfo(filePath);
            try
            {
                var fileHandle = new FileHandle(fileInfo.DirectoryName, 
                                                fileInfo.Length,
                                                fileInfo.Name,
                                                accessStatus);
                return fileHandle;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            return default(FileHandle);
        }
    }
}
