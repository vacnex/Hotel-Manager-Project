namespace Model.Frameworks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_account
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Pass { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
