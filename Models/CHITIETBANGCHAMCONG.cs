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
        [StringLength(1)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string MABANGCHAMCONG { get; set; }

        [StringLength(1)]
        public string NGAYCHAMCONG { get; set; }

        public virtual BANGCHAMCONG BANGCHAMCONG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
