namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BanXeDap2DbContext : DbContext
    {
        public BanXeDap2DbContext()
            : base("name=BanXeDap2")
        {
        }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<Chi_tiet_don_hang> Chi_tiet_don_hang { get; set; }
        public virtual DbSet<Danh_gia> Danh_gia { get; set; }
        public virtual DbSet<Don_hang> Don_hang { get; set; }
        public virtual DbSet<Khach_hang> Khach_hang { get; set; }
        public virtual DbSet<Khuyen_mai> Khuyen_mai { get; set; }
        public virtual DbSet<Loai_sp> Loai_sp { get; set; }
        public virtual DbSet<San_pham> San_pham { get; set; }
        public virtual DbSet<Thanh_toan> Thanh_toan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.matkhau_admin)
                .IsUnicode(false);

            modelBuilder.Entity<Don_hang>()
                .HasMany(e => e.Chi_tiet_don_hang)
                .WithRequired(e => e.Don_hang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Don_hang>()
                .HasMany(e => e.Thanh_toan)
                .WithRequired(e => e.Don_hang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khach_hang>()
                .HasMany(e => e.Danh_gia)
                .WithRequired(e => e.Khach_hang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khach_hang>()
                .HasMany(e => e.Don_hang)
                .WithRequired(e => e.Khach_hang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khach_hang>()
                .HasMany(e => e.Khuyen_mai)
                .WithRequired(e => e.Khach_hang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loai_sp>()
                .HasMany(e => e.San_pham)
                .WithRequired(e => e.Loai_sp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<San_pham>()
                .HasMany(e => e.Chi_tiet_don_hang)
                .WithRequired(e => e.San_pham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<San_pham>()
                .HasMany(e => e.Danh_gia)
                .WithRequired(e => e.San_pham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<San_pham>()
                .HasMany(e => e.Khuyen_mai)
                .WithRequired(e => e.San_pham)
                .WillCascadeOnDelete(false);
        }
    }
}
