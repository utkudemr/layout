using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class Logs:IEntity
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public DateTime Date { get; set; }
        public string Audit { get; set; }

        [NotMapped]
        public string MethodName { get; set; }

        [NotMapped]
        public string UserName { get; set; }
        [NotMapped]
        public string Type { get; set; }

        [NotMapped]
        public string Controller { get; set; }

        [NotMapped]
        public string ExceptionMessage { get; set; }

        [NotMapped]
        public string BusinessManager { get; set; }
    }
}
