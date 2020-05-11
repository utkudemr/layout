using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using static System.Net.Mime.MediaTypeNames;

namespace Core.Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SESANo { get; set; }
        public string UserImage { get; set; }

        [NotMapped]
        public IFormFile UserImage1 { get; set; }



        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

        public OperationClaim OperationClaim { get; set; }
        public int OperationClaimId { get; set; }

    }
}
