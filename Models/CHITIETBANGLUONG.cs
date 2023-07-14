namespace ManageSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETBANGLUONG")]
    public partial class CHITIETBANGLUONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string MABANGLUONG { get; set; }

        [StringLength(1)]
        public string SONGAYCONG { get; set; }

        [Required]
        [StringLength(1)]
        public string MABANGCHAMCONG { get; set; }

        public virtual BANGCHAMCONG BANGCHAMCONG { get; set; }

        public virtual BANGLUONG BANGLUONG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
