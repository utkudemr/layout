using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class ClaimArea:IEntity
    {
        public int Id { get; set; }


        public OperationClaim OperationClaim { get; set; }
        public Area Area { get; set; }

        public int OperationClaimId { get; set; }
        public int AreaId { get; set; }

    }
}
