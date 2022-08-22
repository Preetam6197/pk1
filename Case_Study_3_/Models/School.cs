using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Case_Study_3_.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }

        public string DName { get; set; }

        public string DType { get; set; }


    }
}
