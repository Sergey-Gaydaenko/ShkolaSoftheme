using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ProtoBuf;

namespace Task
{
    [Serializable]
    public class AnySerializer<T>
    {
        public void BinarySerialize(string fileName, List<T> list)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }

        public List<T> BinaryDeserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                return (List<T>)formatter.Deserialize(fs);
            }
        }

        public void XmlSerialize(List<T> list, string fileName)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(fs, list);
            }
        }

        public List<T> XmlDeserialize(string fileName)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                return (List<T>)xmlFormatter.Deserialize(fs);
            }
        }

        public void JsonSerialize(string fileName, List<T> list)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, list);
            }
        }

        public List<T> JsonDeserialize(string fileName)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                return (List<T>)jsonFormatter.ReadObject(fs);
            }
        }


        public void ProtobufSerialize(string fileName, List<T> list)
        {
            using (var file = File.Create(fileName))
            {
                Serializer.Serialize(file, list);
            }
        }

        public List<T> ProtobufDeserialize(string fileName)
        {
            using (var file = File.OpenRead(fileName))
            {
                return Serializer.Deserialize<List<T>>(file);
            }
        }

        public void ZipSerialize(string fileName, List<T> list)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (GZipStream gs = new GZipStream(fs, CompressionMode.Compress))
                {
                   Serializer.Serialize(gs, list);
                }
            }
        }

        public List<T> ZipDeserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                using (GZipStream gs = new GZipStream(fs, CompressionMode.Decompress))
                {
                    return Serializer.Deserialize<List<T>>(gs);
                }
            }
        }
    }
}

