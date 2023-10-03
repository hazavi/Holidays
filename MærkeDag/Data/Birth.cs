using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MærkeDag.Data
{
    [Table("Birth")]
    public class Birth
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        
    }

}
