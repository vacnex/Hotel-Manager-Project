namespace Model.Frameworks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_servicesuse
    {
        [Key]
        [Column(Order = 0)]
        public int idServiceuse { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string idCard { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string idService { get; set; }

        public int number { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateUse { get; set; }

        [StringLength(5)]
        public string idRoom { get; set; }

        public virtual tbl_customer tbl_customer { get; set; }

        public virtual tbl_room tbl_room { get; set; }

        public virtual tbl_services tbl_services { get; set; }
    }
}
