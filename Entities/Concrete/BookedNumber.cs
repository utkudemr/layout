using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class BookedNumber:IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }

        [NotMapped]
        public string NumberTxt { get; set; }
        public OpportunityDetails OpportunityDetails  { get; set; }
        public int OpportunityDetailsId  { get; set; }
    }
}
