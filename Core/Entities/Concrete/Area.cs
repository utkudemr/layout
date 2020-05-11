using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class Area:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ClaimArea> ClaimArea { get; set; }
    }
}
