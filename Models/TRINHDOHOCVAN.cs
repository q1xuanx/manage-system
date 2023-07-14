namespace ManageSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRINHDOHOCVAN")]
    public partial class TRINHDOHOCVAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRINHDOHOCVAN()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
        }

        [Key]
        [StringLength(1)]
        public string MATRINHDO { get; set; }

        [StringLength(1)]
        public string TENTRINHDO { get; set; }

        [StringLength(1)]
        public string CHUYENNGANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
