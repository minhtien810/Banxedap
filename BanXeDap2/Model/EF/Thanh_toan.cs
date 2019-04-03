namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Thanh_toan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_thanh_toan { get; set; }

        public int id_dh { get; set; }

        public double thanh_tien { get; set; }

        public int so_the_tin_dung { get; set; }

        public int loai_the_tin_dung { get; set; }

        public virtual Don_hang Don_hang { get; set; }
    }
}
