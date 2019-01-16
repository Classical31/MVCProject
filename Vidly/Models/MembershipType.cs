﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        /// <summary>
        /// 1: Pay as You Go
        /// 2: Monthly
        /// 3: Quarterly
        /// 4: Annual
        /// </summary>
        public byte Id { get; set; }
        [Required] public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}