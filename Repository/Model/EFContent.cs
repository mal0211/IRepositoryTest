using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Repository.Model
{
    public partial class EFContent : DbContext
    {
        public EFContent()
        {
        }

        public EFContent(DbContextOptions<EFContent> options)
            : base(options)
        {
        }

        public virtual DbSet<Userinfo> Userinfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=123456;Database=coretest");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Userinfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("userinfo");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email).HasColumnType("varchar(255)");

                entity.Property(e => e.Password).HasColumnType("varchar(255)");

                entity.Property(e => e.UserName).HasColumnType("varchar(255)");
            });
        }
    }
}
