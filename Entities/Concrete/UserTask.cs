using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class UserTask:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }

        public User User { get; set; }
       public  Tasks Task { get; set; }
    }
}
