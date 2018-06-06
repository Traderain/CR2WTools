﻿using System;
using System.IO;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Int16Attribute : CR2WPropertyAttribute
    {
        public Int16Attribute( string name ) : base(name, "Int16") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            return br.ReadInt16();
        }

        public override void Serialize(object value, BinaryWriter bw, CR2WExporter e)
        {
            if(value is Int16 i)
            {
                bw.Write(e.AddNewReference(Name));
                bw.Write(e.AddNewReference(TypeStr));
                bw.Write((uint)6);
                bw.Write(i);
                return;
            }
            throw new UnknownObjectTypeException("[Int64] Value was not a Int16");
        }
    }
}