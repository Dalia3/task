﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FekretyFinal.Models.JsonModel
{
    public class RootObject
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}