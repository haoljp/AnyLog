﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyLog
{
    public interface ILogFactoryProvider
    {
        ILogFactory LogFactory { get; }
    }
}
