﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GanapatiFeeds2.Models
{
    public class Accounts
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}