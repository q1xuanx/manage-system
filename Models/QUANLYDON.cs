namespace ManageSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUANLYDON")]
    public partial class QUANLYDON
    {
        [Key]
        [StringLength(100)]
        public string MADON { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        public DateTime NgayLap { get; set; }

        [Required]
        [StringLength(250)]
        public string NOIDUNG { get; set; }

        public int? TRANGTHAI { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
