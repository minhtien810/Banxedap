namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Danh_gia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_danh_gia { get; set; }

        public int id_kh { get; set; }

        public int id_sp { get; set; }

        [StringLength(250)]
        public string chi_tiet { get; set; }

        public virtual Khach_hang Khach_hang { get; set; }

        public virtual San_pham San_pham { get; set; }
    }
}
