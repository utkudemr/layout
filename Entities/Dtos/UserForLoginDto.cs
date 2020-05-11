using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Weekly.Entities.Dtos
{
    public class UserForLoginDto:IDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
