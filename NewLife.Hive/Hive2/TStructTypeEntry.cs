using System;
using System.Collections.Generic;
using System.Text;
using NewLife.Thrift.Protocol;

namespace NewLife.Hive2
{

#if !SILVERLIGHT
    [Serializable]
#endif
    public partial class TStructTypeEntry : TBase
    {

        public Dictionary<String, Int32> NameToTypePtr { get; set; }

        public TStructTypeEntry()
        {
        }

        public TStructTypeEntry(Dictionary<String, Int32> nameToTypePtr) : this()
        {
            NameToTypePtr = nameToTypePtr;
        }

        public void Read(TProtocol iprot)
        {
            var isset_nameToTypePtr = false;
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.Map)
                        {
                            {
                                NameToTypePtr = new Dictionary<String, Int32>();
                                var _map5 = iprot.ReadMapBegin();
                                for (var _i6 = 0; _i6 < _map5.Count; ++_i6)
                                {
                                    String _key7;
                                    Int32 _val8;
                                    _key7 = iprot.ReadString();
                                    _val8 = iprot.ReadI32();
                                    NameToTypePtr[_key7] = _val8;
                                }
                                iprot.ReadMapEnd();
                            }
                            isset_nameToTypePtr = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
            if (!isset_nameToTypePtr)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            var struc = new TStruct("TStructTypeEntry");
            oprot.WriteStructBegin(struc);
            var field = new TField
            {
                Name = "nameToTypePtr",
                Type = TType.Map,
                ID = 1
            };
            oprot.WriteFieldBegin(field);
            {
                oprot.WriteMapBegin(new TMap(TType.String, TType.I32, NameToTypePtr.Count));
                foreach (var _iter9 in NameToTypePtr.Keys)
                {
                    oprot.WriteString(_iter9);
                    oprot.WriteI32(NameToTypePtr[_iter9]);
                }
                oprot.WriteMapEnd();
            }
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override String ToString()
        {
            var sb = new StringBuilder("TStructTypeEntry(");
            sb.Append("NameToTypePtr: ");
            sb.Append(NameToTypePtr);
            sb.Append(")");
            return sb.ToString();
        }

    }

}
