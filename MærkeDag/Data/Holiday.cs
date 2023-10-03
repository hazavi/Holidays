﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MærkeDag.Data
{
    [Table("Holiday")]
    public class Holiday
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        
    }

}
