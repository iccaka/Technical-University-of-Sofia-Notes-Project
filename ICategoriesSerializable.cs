﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    interface ICategoriesSerializable
    {
        IDictionary<string, ICategory> Categories
        {
            get;
            set;
        }
    }
}
