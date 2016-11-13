using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ProtoBuf;

namespace Task
{
    [Serializable]
    [DataContract]
    [ProtoContract]
    public class MobileOperator
    {
        [DataMember]
        [ProtoMember(4)]
        private List<MobileAccount> _accounts = new List<MobileAccount>(); 
        public MobileAccount CreateAccount(int number)
        {
            var acc = new MobileAccount(number, this);

            if (_accounts.Exists(x => x.Number == number))
            {
                throw new ArgumentException("User with same number already exist!");
            }
            acc.Number = number;
            _accounts.Add(acc);

            acc.OnMessagePost += RouteMessage;
            acc.OnCall += RouteCall;
            return acc;
        }

        private void RouteMessage(int numberTo, string message, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.Exists(x => x.Number == numberTo))
            {
                acc = _accounts.Find(x => x.Number == numberTo);
                acc.ReceiveMessage(numberFrom, message);
            }
        }

        private void RouteCall(int numberTo, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.Exists(x => x.Number == numberTo))
            {
                acc = _accounts.Find(x => x.Number == numberTo);
                acc.ReceiveCall(numberFrom);
            }
        }


        private AnySerializer<MobileAccount> _serializer = new AnySerializer<MobileAccount>();
        public void BinarySerialize()
        {
            _serializer.BinarySerialize("BinarySerializedRepository.dat", _accounts);
        }

        public void BinaryDeserialize()
        {
            _serializer.BinaryDeserialize("BinarySerializedRepository.dat");
        }

        public void XmlSerialize()
        {
            _serializer.XmlSerialize(_accounts, "XmlSerializedRepository.xml");
        }

        public void XmlDeserialize()
        {
            _serializer.XmlDeserialize("XmlSerializedRepository.xml");
        }

        public void JsonSerialize()
        {
            _serializer.JsonSerialize("JsonSerializedRepository.json", _accounts);

        }
        public void JsonDeserialize()
        {
            _serializer.JsonDeserialize("JsonSerializedRepository.json");

        }

        public void ProtobufSerialize()
        {
            _serializer.ProtobufSerialize("protoBufSerializerResult.bin", _accounts);
        }

        public void ProtobufDeserialize()
        {
            _serializer.ProtobufDeserialize("protoBufSerializerResult.bin");
        }

        public void ZipSerialize()
        {
            _serializer.ZipSerialize("ZipSerializer.zip", _accounts);
        }

        public void ZipDeserialize()
        {
            _serializer.ZipDeserialize("ZipSerializer.zip");
        }
    }
}
