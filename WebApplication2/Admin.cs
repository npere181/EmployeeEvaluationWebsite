namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        [StringLength(10)]
        public string Auserid { get; set; }

        [Required]
        [StringLength(50)]
        public string Aname { get; set; }

        [Required]
        [StringLength(50)]
        public string Apassword { get; set; }

        [Required]
        [StringLength(10)]
        public string Atrade { get; set; }

        public bool? IsActive { get; set; }
       
        
        
    }
}
