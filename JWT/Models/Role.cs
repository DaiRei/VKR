﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWT.Models
{
    public class Role
    {
       [Key]
       public int Id { get; set; }
       public string Roles { get; set; }
        

    }
}
