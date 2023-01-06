using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EF_Relations.Data.Models;

#nullable disable

namespace EF_Relations.Data
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Contenu> Contenus { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.IdCommande)
                    .HasName("PRIMARY");

                entity.ToTable("commandes");

                entity.Property(e => e.IdCommande)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCommande");

                entity.Property(e => e.LibelleCommande)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("libelleCommande");
            });

            modelBuilder.Entity<Contenu>(entity =>
            {
                entity.HasKey(e => new { e.IdProduit, e.IdCommande })
                    .HasName("PRIMARY");

                entity.ToTable("contenus");

                entity.HasIndex(e => e.IdCommande, "fk_contenus_commandes");

                entity.Property(e => e.IdProduit)
                    .HasColumnType("int(11)")
                    .HasColumnName("idProduit");

                entity.Property(e => e.IdCommande)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCommande");

                entity.Property(e => e.Quantite).HasColumnType("int(11)");

                entity.HasOne(d => d.Cde)
                    .WithMany(p => p.Contenus)
                    .HasForeignKey(d => d.IdCommande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contenus_commandes");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.Contenus)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contenus_produits");
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(e => e.IdProduit)
                    .HasName("PRIMARY");

                entity.ToTable("produits");

                entity.Property(e => e.IdProduit).HasColumnType("int(11)");

                entity.Property(e => e.LibelleProduit)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
