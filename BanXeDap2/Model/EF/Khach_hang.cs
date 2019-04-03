namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Khach_hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khach_hang()
        {
            Danh_gia = new HashSet<Danh_gia>();
            Don_hang = new HashSet<Don_hang>();
            Khuyen_mai = new HashSet<Khuyen_mai>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kh { get; set; }

        [StringLength(50)]
        public string ten_kh { get; set; }

        [StringLength(50)]
        public string dia_chi { get; set; }

        [StringLength(50)]
        public string sdt { get; set; }

        public DateTime? ngay_sinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Danh_gia> Danh_gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Don_hang> Don_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Khuyen_mai> Khuyen_mai { get; set; }
    }
}
