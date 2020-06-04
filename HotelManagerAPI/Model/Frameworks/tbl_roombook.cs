namespace Model.Frameworks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_roombook
    {
        [Key]
        public int idRoombook { get; set; }

        [Required]
        [StringLength(12)]
        public string idCard { get; set; }

        [Required]
        [StringLength(5)]
        public string idRoom { get; set; }

        [Column(TypeName = "date")]
        public DateTime startDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? endDate { get; set; }

        [Required]
        [StringLength(30)]
        public string staffName { get; set; }

        public virtual tbl_customer tbl_customer { get; set; }

        public virtual tbl_room tbl_room { get; set; }
    }
}
