namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lop")]
    public partial class Lop
    {
        [Key]
        [StringLength(10)]
        public string IdLop { get; set; }

        [StringLength(50)]
        public string IdGVCN { get; set; }

        [StringLength(20)]
        public string TenLop { get; set; }

        public int? SiSo { get; set; }

        [StringLength(10)]
        public string Khoi { get; set; }
    }
}
