using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class FrameworkForecastSub:IEntity
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int ProductTypeId { get; set; }

        [NotMapped]
        public int MonthNumber { get; set; }
        [NotMapped]
        public int Year { get; set; }
        public DateTime Date { get; set; }
        public int FrameworkForecastId { get; set; }
        public ProductType ProductType { get; set; }

        [NotMapped]
        public string ValueTxt { get; set; }
    }
}
