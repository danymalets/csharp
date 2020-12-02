﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL
{
    public interface IConfigurationParser
    {
        T Parse<T>(string contents) where T : new();
    }
}

