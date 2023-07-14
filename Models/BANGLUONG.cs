namespace ManageSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGLUONG")]
    public partial class BANGLUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANGLUONG()
        {
            CHITIETBANGLUONGs = new HashSet<CHITIETBANGLUONG>();
        }

        [Key]
        [StringLength(1)]
        public string MABANGLUONG { get; set; }

        public double? HESOPHUCAP { get; set; }

        public double? HESOLUONG { get; set; }

        public double? LUONGCOBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANGLUONG> CHITIETBANGLUONGs { get; set; }
    }
}
