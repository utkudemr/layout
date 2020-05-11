using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class FrameworkForecast:IEntity
    {
        public int Id { get; set; }

        [NotMapped]
        public int Year { get; set; }
        [NotMapped]
        public int Month { get; set; }

        [NotMapped]
        public string MonthText { get; set; }

        public string Definition { get; set; }
        public List<FrameworkForecastSub> List { get; set; }
    }
}
