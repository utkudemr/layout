using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class Slot:IEntity
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public int Class { get; set; }
        public int TankType { get; set; }
        public int OLTC { get; set; }
        public int Earthing { get; set; }
        public int Reactor { get; set; }
        public int CableBox { get; set; }
        public int OilGas { get; set; }
        public int DoubleLayer { get; set; }
        public int Fan { get; set; }
        public int AltmiskvUzeri { get; set; }
        public int HG { get; set; }
        public int V1V2 { get; set; }
        public int Enclosure { get; set; }
        public double SlotValue { get; set; }

        [NotMapped]
        public string SlotValueTxt { get; set; }
    }
}
