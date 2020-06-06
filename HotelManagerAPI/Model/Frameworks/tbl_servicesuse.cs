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
        public int idServiceuse { get; set; }

        [Required]
        [StringLength(12)]
        public string idCard { get; set; }

        [Required]
        [StringLength(10)]
        public string idService { get; set; }

        public int number { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateUse { get; set; }

        public virtual tbl_customer tbl_customer { get; set; }

        public virtual tbl_services tbl_services { get; set; }
    }
}
