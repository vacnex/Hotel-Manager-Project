namespace Model.Frameworks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_services()
        {
            tbl_servicesuse = new HashSet<tbl_servicesuse>();
        }

        [Key]
        [StringLength(10)]
        public string idService { get; set; }

        [Required]
        [StringLength(50)]
        public string serName { get; set; }

        public double serPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string serUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_servicesuse> tbl_servicesuse { get; set; }
    }
}
