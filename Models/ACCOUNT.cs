namespace ManageSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(50)]
        public string IDACCOUNT { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        [StringLength(50)]
        public string PASSWORD { get; set; }

        public int? ROLE { get; set; }

        public int? TRANGTHAI { get; set; }

        [Required]
        [StringLength(50)]
        public string MANV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
