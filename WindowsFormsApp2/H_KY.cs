namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class H_KY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public H_KY()
        {
            Diem_HS = new HashSet<Diem_HS>();
        }

        [Key]
        [StringLength(10)]
        public string idHocKy { get; set; }

        [StringLength(10)]
        public string TenHK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TG_BD { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TG_KT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem_HS> Diem_HS { get; set; }
    }
}
