namespace ManageSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGCHAMCONG")]
    public partial class BANGCHAMCONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANGCHAMCONG()
        {
            CHITIETBANGCHAMCONGs = new HashSet<CHITIETBANGCHAMCONG>();
            CHITIETBANGLUONGs = new HashSet<CHITIETBANGLUONG>();
        }

        [Key]
        [StringLength(1)]
        public string MABANGCHAMCONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANGCHAMCONG> CHITIETBANGCHAMCONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANGLUONG> CHITIETBANGLUONGs { get; set; }
    }
}
