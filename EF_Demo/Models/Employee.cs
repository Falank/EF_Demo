using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EF_Demo.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}