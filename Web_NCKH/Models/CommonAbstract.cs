﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_NCKH.Models
{
    public abstract class CommonAbstract
    {
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedrDate { get; set; }
        public string ModifierBy { get; set; }
    }
}