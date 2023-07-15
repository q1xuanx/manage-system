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
            CHITIETBANGLUONGs = new HashSet<CHITIETBANGLUONG>();
        }

        [Key]
        [StringLength(50)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string TENNV { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        public int? GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string DANTOC { get; set; }

        [Required]
        [StringLength(50)]
        public string MAPHONGBAN { get; set; }

        [Required]
        [StringLength(50)]
        public string MATRINHDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNT> ACCOUNTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANGCHAMCONG> CHITIETBANGCHAMCONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANGLUONG> CHITIETBANGLUONGs { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        public virtual TRINHDOHOCVAN TRINHDOHOCVAN { get; set; }
    }
}
