﻿using Biz1BookPOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Biz1PosApi.Models
{
    public class ScreenRule
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Role")]
        public int? RoleId { get; set; }
        public virtual Role Role { get; set; }

        [ForeignKey("Company")]
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public string Rules { get; set; }
    }
}
