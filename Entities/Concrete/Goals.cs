using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class Goals:IEntity
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public DateTime Datetime { get; set; }

        [NotMapped]
        public string Datetime1 { get; set; }
        public string Definition { get; set; }
        public double Target1 { get; set; }
        public double Target2 { get; set; }
        public double Target3 { get; set; }
        public double Target4 { get; set; }
    }
}
