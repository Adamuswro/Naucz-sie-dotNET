﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25FactoryMethod
{
    public class Page
    {
        public string PageTitle { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return $"{PageTitle}";
        }
    }
}
