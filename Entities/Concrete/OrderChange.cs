using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public  class OrderChange:IEntity
    {
        public int Id { get; set; }
        public int Value { get; set; }

        [NotMapped]
        public int Year { get; set; }
        [NotMapped]
        public int Month { get; set; }
        public DateTime Date { get; set; }
        public string ProjectNumber { get; set; }

        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
    }
}
