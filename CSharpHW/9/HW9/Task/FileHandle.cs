using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public struct FileHandle
    {
        public long FileSize { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public FileAccessEnum AccessStatus { get; set; }

        public FileHandle(string filePath, long fileSize, string fileName, FileAccessEnum accessStatus)
        {
            FileSize = fileSize;
            FilePath = filePath;
            FileName = fileName;
            AccessStatus = accessStatus;
        }

        public override string ToString()
        {
            return FileName + ", size: " + FileSize + ", FilePath: " + FilePath + " accessStatus: " + AccessStatus;
        }
    }
}
