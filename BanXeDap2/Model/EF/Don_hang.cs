namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Don_hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Don_hang()
        {
            Chi_tiet_don_hang = new HashSet<Chi_tiet_don_hang>();
            Thanh_toan = new HashSet<Thanh_toan>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_dh { get; set; }

        public int id_kh { get; set; }

        public DateTime ngay_lap { get; set; }

        public DateTime ngay_giao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chi_tiet_don_hang> Chi_tiet_don_hang { get; set; }

        public virtual Khach_hang Khach_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thanh_toan> Thanh_toan { get; set; }
    }
}
