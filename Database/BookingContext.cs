using System;
using booking.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace booking.Database
{
    public partial class BookingContext : DbContext
    {
        public BookingContext()
        {
        }

        public BookingContext(DbContextOptions<BookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Dotare> Dotari { get; set; }
        public virtual DbSet<Camera> Camere { get; set; }
        public virtual DbSet<DotareCamera> DotariCamere { get; set; }
        public virtual DbSet<Serviciu> Servicii { get; set; }
        public virtual DbSet<Oferta> Oferte { get; set; }
        public virtual DbSet<Imagine> Imagini { get; set; }
        public virtual DbSet<Pret> Preturi { get; set; }
        public virtual DbSet<ServiciiOferta> ServiciiOferte { get; set; }
        public virtual DbSet<Rezervare> Rezervari { get; set; }
        public virtual DbSet<ServiciiRezervare> ServiciiRezervari { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=booking;Username=postgres;Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("character varying");

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasColumnType("character varying");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("character varying");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
