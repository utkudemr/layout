using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class Tasks:IEntity
    {
        public int Id { get; set; }
        public int OpportunityId { get; set; }
        public string Explanation { get; set; }
        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public DateTime TaskDate { get; set; }

        [NotMapped]
        public string TaskDateStr { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CompleteDate { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; }
        public Opportunity Opportunity { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }

        [NotMapped]
        public int UserId { get; set; }
        public List<UserTask> UserList { get; set; }

        [NotMapped]
        public List<string> UserIdList { get; set; }
    }
}
