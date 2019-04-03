namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class San_pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public San_pham()
        {
            Chi_tiet_don_hang = new HashSet<Chi_tiet_don_hang>();
            Danh_gia = new HashSet<Danh_gia>();
            Khuyen_mai = new HashSet<Khuyen_mai>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_sp { get; set; }

        [Required]
        [StringLength(50)]
        public string ten_sp { get; set; }

        public int id_loai_sp { get; set; }

        public double gia { get; set; }

        [Required]
        [StringLength(250)]
        public string chi_tiet { get; set; }

        public bool trang_thai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chi_tiet_don_hang> Chi_tiet_don_hang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Danh_gia> Danh_gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Khuyen_mai> Khuyen_mai { get; set; }

        public virtual Loai_sp Loai_sp { get; set; }
    }
}
