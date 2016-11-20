using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Threading;

namespace Task
{
    public static class Archivator
    {
        public static void ZipFilesInDirectory(object path)
        {
            string directory = Convert.ToString(path);
            if (Directory.Exists(directory))
            {
                string[] dirs = Directory.GetDirectories(directory);
                foreach (string s in dirs)
                {
                    Thread myThread = new Thread(ZipFilesInDirectory);
                    myThread.Start(s);
                }

                string[] files = Directory.GetFiles(directory);
                foreach (string s in files)
                {
                    string tmpDir = directory + "\\" + "temp";
                    Directory.CreateDirectory(tmpDir);

                    FileInfo fi = new FileInfo(s);
                    fi.CopyTo(tmpDir + "\\" + fi.Name);

                    string startPath = tmpDir;
                    string zipPath = s.Substring(0, s.IndexOf(".")) + ".zip";

                    ZipFile.CreateFromDirectory(startPath, zipPath);
                    Console.WriteLine("Archive file: {0}", s);
                    Directory.Delete(tmpDir, true);
                }
            }
            else
            {
                Console.WriteLine("Can't find this folder");
            }
        }

        public static void GetFileFromAchive(object path)
        {
            string directory = Convert.ToString(path);
            if (Directory.Exists(directory))
            {
                string[] dirs = Directory.GetDirectories(directory);
                foreach (string s in dirs)
                {
                    Thread myThread = new Thread(GetFileFromAchive);
                    myThread.Start(s);
                }

                string[] files = Directory.GetFiles(directory);

                foreach (var s in files)
                {
                    FileInfo fi = new FileInfo(s);
                    if (fi.Extension == ".zip" || fi.Extension == ".rar")
                    {
                        if (files.Contains(fi.Name))
                        {
                            File.Delete(directory + "\\" + fi.Name);
                        }

                        string zipPath = s;
                        ZipFile.ExtractToDirectory(zipPath, directory);
                        Console.WriteLine("dearchive file: {0}", s);
                    }
                }
            }
        }
    }
}
