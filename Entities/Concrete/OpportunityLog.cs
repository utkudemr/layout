using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class OpportunityLog:IEntity
    {
        public int Id { get; set; }
        public int OpportunityId { get; set; }
        public Opportunity Opportunity { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string Log { get; set; }
        public string IconClass { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
