using System;
using System.Collections.Generic;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace PlantGuide.DataAccess.EF;

public partial class PlantguideContext : DbContext
{
    public PlantguideContext()
    {
    }

    public PlantguideContext(DbContextOptions<PlantguideContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Climate> Climates { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<FamilyPlant> FamilyPlants { get; set; }

    public virtual DbSet<FloweringSeasonPlant> FloweringSeasonPlants { get; set; }

    public virtual DbSet<Origin> Origins { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<Plant> Plants { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<SourcePlant> SourcePlants { get; set; }

    public virtual DbSet<TypeSeason> TypeSeasons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-S7D9M3G\\SQLEXPRESS;Database=PLANTGUIDE;Integrated Security=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Climate>(entity =>
        {
            entity.HasKey(e => e.ClimateId).HasName("PK__Climate__55D2DDAFDCD706A2");

            entity.ToTable("Climate");

            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Plant).WithMany(p => p.Climates)
                .HasForeignKey(d => d.PlantId)
                .HasConstraintName("FK__Climate__PlantId__59FA5E80");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Country__10D1609FD3D2CEAE");

            entity.ToTable("Country");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Family>(entity =>
        {
            entity.HasKey(e => e.FamilyId).HasName("PK__Family__41D82F6B2831C83D");

            entity.ToTable("Family");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FamilyPlant>(entity =>
        {
            entity.HasKey(e => e.FamilyPlantId).HasName("PK__FamilyPl__BE40E246F755D911");

            entity.ToTable("FamilyPlant");

            entity.HasOne(d => d.Family).WithMany(p => p.FamilyPlants)
                .HasForeignKey(d => d.FamilyId)
                .HasConstraintName("FK__FamilyPla__Famil__5441852A");

            entity.HasOne(d => d.Plant).WithMany(p => p.FamilyPlants)
                .HasForeignKey(d => d.PlantId)
                .HasConstraintName("FK__FamilyPla__Plant__534D60F1");
        });

        modelBuilder.Entity<FloweringSeasonPlant>(entity =>
        {
            entity.HasKey(e => e.FloweringSeasonPlantId).HasName("PK__Flowerin__8CD61782C83D2AC3");

            entity.ToTable("FloweringSeasonPlant");

            entity.HasOne(d => d.Plant).WithMany(p => p.FloweringSeasonPlants)
                .HasForeignKey(d => d.PlantId)
                .HasConstraintName("FK__Flowering__Plant__6477ECF3");

            entity.HasOne(d => d.TypeSeason).WithMany(p => p.FloweringSeasonPlants)
                .HasForeignKey(d => d.TypeSeasonId)
                .HasConstraintName("FK__Flowering__TypeS__656C112C");
        });

        modelBuilder.Entity<Origin>(entity =>
        {
            entity.HasKey(e => e.OriginId).HasName("PK__Origin__171FA226440757CA");

            entity.ToTable("Origin");

            entity.HasOne(d => d.Country).WithMany(p => p.Origins)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__Origin__CountryI__4E88ABD4");

            entity.HasOne(d => d.Plant).WithMany(p => p.Origins)
                .HasForeignKey(d => d.PlantId)
                .HasConstraintName("FK__Origin__PlantId__4D94879B");
        });

        modelBuilder.Entity<Photo>(entity =>
        {
            entity.HasKey(e => e.PhotoId).HasName("PK__Photo__21B7B5E25D066AA2");

            entity.ToTable("Photo");

            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Plant).WithMany(p => p.Photos)
                .HasForeignKey(d => d.PlantId)
                .HasConstraintName("FK__Photo__PlantId__571DF1D5");
        });

        modelBuilder.Entity<Plant>(entity =>
        {
            entity.HasKey(e => e.PlantId).HasName("PK__Plant__98FE395C0C7D3ADD");

            entity.ToTable("Plant");

            entity.Property(e => e.CommonName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.ScientificName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.HasKey(e => e.SourceId).HasName("PK__Source__16E019190237B249");

            entity.ToTable("Source");

            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<SourcePlant>(entity =>
        {
            entity.HasKey(e => e.SourcesPlantId).HasName("PK__SourcePl__8423F49CBB37CE6A");

            entity.ToTable("SourcePlant");

            entity.HasOne(d => d.Plant).WithMany(p => p.SourcePlants)
                .HasForeignKey(d => d.PlantId)
                .HasConstraintName("FK__SourcePla__Plant__5EBF139D");

            entity.HasOne(d => d.Source).WithMany(p => p.SourcePlants)
                .HasForeignKey(d => d.SourceId)
                .HasConstraintName("FK__SourcePla__Sourc__5FB337D6");
        });

        modelBuilder.Entity<TypeSeason>(entity =>
        {
            entity.HasKey(e => e.TypeSeasonId).HasName("PK__TypeSeas__86276B8B1FBABCD6");

            entity.ToTable("TypeSeason");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
