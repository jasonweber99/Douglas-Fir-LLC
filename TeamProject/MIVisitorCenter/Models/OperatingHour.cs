﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MIVisitorCenter
{
    public partial class OperatingHour
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(16)]
        public int Day { get; set; }
        public DateTime? Open { get; set; }
        public DateTime? Close { get; set; }
        [Column("BusinessID")]
        public int? BusinessId { get; set; }

        [ForeignKey(nameof(BusinessId))]
        [InverseProperty("OperatingHours")]
        public virtual Business Business { get; set; }
    }
}
