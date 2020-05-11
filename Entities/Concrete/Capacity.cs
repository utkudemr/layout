using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class Capacity:IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [NotMapped]
        public int Year { get; set; }
        [NotMapped]
        public int Month { get; set; }

        [NotMapped]
        public string ValText { get; set; }

       


        public int ProductTypeId { get; set; }
        public double Value { get; set; }
    }
}
