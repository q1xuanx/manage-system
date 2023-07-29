namespace ManageSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            ACCOUNTs = new HashSet<ACCOUNT>();
            CHITIETBANGCHAMCONGs = new HashSet<CHITIETBANGCHAMCONG>();
            QUANLYDONs = new HashSet<QUANLYDON>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNV { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        public int GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYSINH { get; set; }

        [Required]
        [StringLength(10)]
        public string MACHUCVU { get; set; }

        [Required]
        [StringLength(10)]
        public string MAPHONGBAN { get; set; }

        [Required]
        [StringLength(10)]
        public string MABANGLUONG { get; set; }

        [Required]
        [StringLength(50)]
        public string TINHTRANG { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNT> ACCOUNTs { get; set; }

        public virtual BANGLUONG BANGLUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANGCHAMCONG> CHITIETBANGCHAMCONGs { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUANLYDON> QUANLYDONs { get; set; }
    }
}
