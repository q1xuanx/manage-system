namespace ManageSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETBANGCHAMCONG")]
    public partial class CHITIETBANGCHAMCONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime NGAYCHAMCONG { get; set; }

        public TimeSpan? GIOVAO { get; set; }

        public TimeSpan? GIORA { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
