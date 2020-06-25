namespace Model.Frameworks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_room()
        {
            tbl_roombook = new HashSet<tbl_roombook>();
        }

        [Key]
        [StringLength(5)]
        public string idRoom { get; set; }

        [Required]
        [StringLength(25)]
        public string rType { get; set; }

        public int rPrice { get; set; }

        [Required]
        [StringLength(15)]
        public string rStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_roombook> tbl_roombook { get; set; }
    }
}
