﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public struct SEmbedded
    {
        public uint importIndex;
        public uint path;
        public ulong pathHash;
        public byte[] data;
    }
}
