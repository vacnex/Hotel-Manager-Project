namespace Model.Frameworks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_customer()
        {
            tbl_roombook = new HashSet<tbl_roombook>();
            tbl_servicesuse = new HashSet<tbl_servicesuse>();
        }

        [Key]
        [StringLength(12)]
        public string idCard { get; set; }

        [Required]
        [StringLength(255)]
        public string cusName { get; set; }

        [Required]
        [StringLength(255)]
        public string cusAddress { get; set; }

        [Required]
        [StringLength(5)]
        public string cusGender { get; set; }

        [StringLength(15)]
        public string cusPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_roombook> tbl_roombook { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_servicesuse> tbl_servicesuse { get; set; }
    }
}
