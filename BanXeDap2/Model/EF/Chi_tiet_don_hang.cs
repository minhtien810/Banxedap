namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Chi_tiet_don_hang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_ctdh { get; set; }

        public int id_dh { get; set; }

        public int id_sp { get; set; }

        public int so_luong { get; set; }

        public double don_gia { get; set; }

        public virtual Don_hang Don_hang { get; set; }

        public virtual San_pham San_pham { get; set; }
    }
}
