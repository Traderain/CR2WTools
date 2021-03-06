﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class CSwfResource : CResource
    {
        [W3Type("linkageName")]
        public string LinkageName { get; set; }

        [W3Type("fonts")]
        [W3ArrayFlags(2, 0)]
        public Array<SSwfFontDesc> Fonts { get; set; }

        [W3Type("textures")]
        [W3ArrayFlags(2, 0)]
        public Array<Handle<CSwfTexture>> Textures { get; set; }

        [W3Type("header")]
        public SSwfHeaderInfo Header { get; set; }

        [W3Type("imageImportOptions")]
        public string ImageImportOptions { get; set; }

        public byte[] Data { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            /* - ToDo 
             *   parse the remaining bytes that is the swf resource.
             */
        }
    }
}