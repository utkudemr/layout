using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class Opportunity:IEntity
    {
      
        public int Id { get; set; }
        public string OppurtunityNo { get; set; }

        public Country Country { get; set; }
        public int Acc_Country { get; set; }
        public int Des_Country { get; set; } 

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public int EndUserCustomerId { get; set; }

        public string ProjectName { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        [NotMapped]
        public int CreatedTime1 { get; set; }


        [NotMapped]
        public string UsersOpportunity { get; set; }
        public int OppType { get; set; }

        public EndUserSegment EndUserSegment { get; set; }
        public int EndUserSegmentId { get; set; }

        public bool isDeleted { get; set; }

        public Status Status { get; set; }
        public int StatusId { get; set; }

        public int ElepphantProject { get; set; }
        public virtual List<OpportunityDetails> OpportunityDetails { get; set; }
    }
}
