﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Common.FileParser
{
    public class FileFooterParserBase : IFileSection
    {
        public FileEntityBase ReadEntry(string fileLine)
        {
            throw new NotImplementedException();
        }
    }
}
