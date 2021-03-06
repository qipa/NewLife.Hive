using System;
using System.Text;
using NewLife.Thrift.Protocol;

namespace NewLife.Hive2
{

#if !SILVERLIGHT
    [Serializable]
#endif
    public partial class TI64Value : TBase
    {
        private Int64 _value;

        public Int64 Value
        {
            get
            {
                return _value;
            }
            set
            {
                __isset.value = true;
                _value = value;
            }
        }


        public Isset __isset;
#if !SILVERLIGHT
        [Serializable]
#endif
        public struct Isset
        {
            public Boolean value;
        }

        public TI64Value()
        {
        }

        public void Read(TProtocol iprot)
        {
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
                        if (field.Type == TType.I64)
                        {
                            Value = iprot.ReadI64();
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
        }

        public void Write(TProtocol oprot)
        {
            var struc = new TStruct("TI64Value");
            oprot.WriteStructBegin(struc);
            var field = new TField();
            if (__isset.value)
            {
                field.Name = "value";
                field.Type = TType.I64;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                oprot.WriteI64(Value);
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override String ToString()
        {
            var sb = new StringBuilder("TI64Value(");
            sb.Append("Value: ");
            sb.Append(Value);
            sb.Append(")");
            return sb.ToString();
        }

    }

}
