﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace White.Lagoon.Domain.Entities
{
    public  class ApplicationUser : IdentityUser
    {
        public string  Name { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
