using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [AttributeUsage(AttributeTargets.Method)]
    public class OperatorMessage : Attribute
    {
        private OperatorMessageType _messageType;

        public OperatorMessage(OperatorMessageType type)
        {
            _messageType = type;
        }

        public OperatorMessageType MessageType
        {
            get { return _messageType; }
        }
    }
}
