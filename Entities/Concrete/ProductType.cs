using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class ProductType:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
    }
}
