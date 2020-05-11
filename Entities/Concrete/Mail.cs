using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class Mail:IEntity
    {
        public int Id { get; set; }
        public string SenderMail { get; set; }
        public string SenderPassword { get; set; }
        public bool SSL { get; set; }
        public int Port { get; set; }
        public string Smtp { get; set; }

        

    }
}
