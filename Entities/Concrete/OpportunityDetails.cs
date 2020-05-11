using Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Weekly.Entities.Concrete
{
    public class OpportunityDetails:IEntity
    {
        public int Id { get; set; }
        
        public int OpportunityId { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public Opportunity Opportunity { get; set; }

        public double UnitPrice { get; set; }

        public ProductType ProductType { get; set; }
        public Status Status { get; set; }
        public int ProductTypeId { get; set; }

        public double Quantity { get; set; }

        public double Power_Onan { get; set; }
        public double Power_Onaf { get; set; }
        public double Voltage_HV { get; set; }
        public double Voltage_LV { get; set; }
        
        public DateTime OrderDate { get; set; }

        [NotMapped]
        public string OrderDate1 { get; set; }



        //Haftanın ilk günü otomatik tarih ata.
        public DateTime CreatedDate { get; set; }

      
        public int StatusId { get; set; }
        public bool IsDeleted { get; set; }


        public int TechnicalStudy { get; set; }
        public int OLTCOffer { get; set; }
        public int TankType { get; set; }
        public int Earthing { get; set; }
        public int Reactor { get; set; }
        public int CableBox { get; set; }
        public int OilGas { get; set; }
        public int DoubleLayer { get; set; }
        public int Fan { get; set; }
        public int Forecast { get; set; }
        public int Enclosure { get; set; }
        public int ETO { get; set; }
        public int HG { get; set; }
        public double LeadTime { get; set; }

        public int BestEstimation { get; set; }
        public IEnumerable<BookedNumber> BookedNumbers { get; set; }


        public string LostComment { get; set; }
        public Nullable<int> LostStatusId { get; set; }
        public LostStatus LostStatus { get; set; }

    }
}
