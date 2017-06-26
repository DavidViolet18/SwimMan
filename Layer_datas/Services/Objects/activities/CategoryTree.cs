﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_datas.Services.Objects.activities
{
    public class CategoryTree
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActivityTree> activities { get; set; }

    }
}
