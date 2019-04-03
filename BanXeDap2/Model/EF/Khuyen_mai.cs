namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Khuyen_mai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_khuyen_mai { get; set; }

        public int id_kh { get; set; }

        public int id_sp { get; set; }

        public DateTime ngay_bat_dau { get; set; }

        public DateTime ngay_het_han { get; set; }

        [Required]
        [StringLength(1)]
        public string chitiet_khuyen_mai { get; set; }

        public virtual Khach_hang Khach_hang { get; set; }

        public virtual San_pham San_pham { get; set; }
    }
}
