﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesInfo.Core
{
    public interface IDocumentSettings
    {
        string DefaultFileName { get; }
        string DefaultExtention { get; }
        string DefaultFilter { get; }
    }
}
