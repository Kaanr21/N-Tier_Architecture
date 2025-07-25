﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Entity.Entites
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int Order { get; set; }
        public bool Status { get; set; }
    }
}
