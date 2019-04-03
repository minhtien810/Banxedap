namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admin")]
    public partial class admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_admin { get; set; }

        [StringLength(50)]
        public string ten_admin { get; set; }

        [StringLength(250)]
        public string matkhau_admin { get; set; }
    }
}
