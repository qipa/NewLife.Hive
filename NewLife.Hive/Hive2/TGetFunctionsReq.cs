using System;
using System.Text;
using NewLife.Thrift.Protocol;

namespace NewLife.Hive2
{

#if !SILVERLIGHT
    [Serializable]
#endif
    public partial class TGetFunctionsReq : TBase
    {
        private String _catalogName;
        private String _schemaName;

        public TSessionHandle SessionHandle { get; set; }

        public String CatalogName
        {
            get
            {
                return _catalogName;
            }
            set
            {
                __isset.catalogName = true;
                _catalogName = value;
            }
        }

        public String SchemaName
        {
            get
            {
                return _schemaName;
            }
            set
            {
                __isset.schemaName = true;
                _schemaName = value;
            }
        }

        public String FunctionName { get; set; }


        public Isset __isset;
#if !SILVERLIGHT
        [Serializable]
#endif
        public struct Isset
        {
            public Boolean catalogName;
            public Boolean schemaName;
        }

        public TGetFunctionsReq()
        {
        }

        public TGetFunctionsReq(TSessionHandle sessionHandle, String functionName) : this()
        {
            SessionHandle = sessionHandle;
            FunctionName = functionName;
        }

        public void Read(TProtocol iprot)
        {
            var isset_sessionHandle = false;
            var isset_functionName = false;
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
                        if (field.Type == TType.Struct)
                        {
                            SessionHandle = new TSessionHandle();
                            SessionHandle.Read(iprot);
                            isset_sessionHandle = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 2:
                        if (field.Type == TType.String)
                        {
                            CatalogName = iprot.ReadString();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 3:
                        if (field.Type == TType.String)
                        {
                            SchemaName = iprot.ReadString();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 4:
                        if (field.Type == TType.String)
                        {
                            FunctionName = iprot.ReadString();
                            isset_functionName = true;
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
            if (!isset_sessionHandle)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_functionName)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            var struc = new TStruct("TGetFunctionsReq");
            oprot.WriteStructBegin(struc);
            var field = new TField
            {
                Name = "sessionHandle",
                Type = TType.Struct,
                ID = 1
            };
            oprot.WriteFieldBegin(field);
            SessionHandle.Write(oprot);
            oprot.WriteFieldEnd();
            if (CatalogName != null && __isset.catalogName)
            {
                field.Name = "catalogName";
                field.Type = TType.String;
                field.ID = 2;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(CatalogName);
                oprot.WriteFieldEnd();
            }
            if (SchemaName != null && __isset.schemaName)
            {
                field.Name = "schemaName";
                field.Type = TType.String;
                field.ID = 3;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(SchemaName);
                oprot.WriteFieldEnd();
            }
            field.Name = "functionName";
            field.Type = TType.String;
            field.ID = 4;
            oprot.WriteFieldBegin(field);
            oprot.WriteString(FunctionName);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override String ToString()
        {
            var sb = new StringBuilder("TGetFunctionsReq(");
            sb.Append("SessionHandle: ");
            sb.Append(SessionHandle == null ? "<null>" : SessionHandle.ToString());
            sb.Append(",CatalogName: ");
            sb.Append(CatalogName);
            sb.Append(",SchemaName: ");
            sb.Append(SchemaName);
            sb.Append(",FunctionName: ");
            sb.Append(FunctionName);
            sb.Append(")");
            return sb.ToString();
        }

    }

}
