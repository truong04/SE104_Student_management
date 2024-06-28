namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Diem_HS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string idHocSinh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string idMonHoc { get; set; }

        [StringLength(10)]
        public string idHocKy { get; set; }

        public double? Diem15 { get; set; }

        public double? Diem45 { get; set; }

        public virtual H_KY H_KY { get; set; }

        public virtual HSinh HSinh { get; set; }

        public virtual MONHOC MONHOC { get; set; }
    }
}
