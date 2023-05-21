using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BSBookingQuery.DAL.Entities;

public partial class HotelBookingDbContext : DbContext
{
    public HotelBookingDbContext()
    {
    }

    public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingDetail> BookingDetails { get; set; }

    public virtual DbSet<BookingStatus> BookingStatuses { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Guest> Guests { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SABBIRBGITACC\\SQLEXPRESS;Initial Catalog=HotelBookingDB;Persist Security Info=False;User ID=sa;Password=Sabbir@1226;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.ToTable("Booking");
        });

        modelBuilder.Entity<BookingDetail>(entity =>
        {
            entity.ToTable("BookingDetail");

            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTo).HasColumnType("datetime");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK_BookingDetail_Booking");

            entity.HasOne(d => d.BookingStatus).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.BookingStatusId)
                .HasConstraintName("FK_BookingDetail_BookingStatus");

            entity.HasOne(d => d.Room).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_BookingDetail_Rooms");
        });

        modelBuilder.Entity<BookingStatus>(entity =>
        {
            entity.ToTable("BookingStatus");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Country).WithMany(p => p.Cities)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Cities_Country");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.ToTable("Comment");

            entity.Property(e => e.CommentTime).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.Guest).WithMany(p => p.Comments)
                .HasForeignKey(d => d.GuestId)
                .HasConstraintName("FK_Comment_Guest");

            entity.HasOne(d => d.Hotel).WithMany(p => p.Comments)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK_Comment_Hotel");

            entity.HasOne(d => d.ParentKeyNavigation).WithMany(p => p.InverseParentKeyNavigation)
                .HasForeignKey(d => d.ParentKey)
                .HasConstraintName("FK_Comment_Comment1");

            entity.HasOne(d => d.UserReviewNavigation).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserReview)
                .HasConstraintName("FK_Comment_Ratings");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Guest>(entity =>
        {
            entity.ToTable("Guest");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.ToTable("Hotel");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.HotelCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ImagePath)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Rating).WithMany(p => p.Hotels)
                .HasForeignKey(d => d.RatingId)
                .HasConstraintName("FK_Hotel_Rating");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.ToTable("Position");

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.RatingId).HasName("PK_Ratings");

            entity.ToTable("Rating");

            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK_Rooms");

            entity.ToTable("Room");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Hotel).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK_Rooms_Rooms");

            entity.HasOne(d => d.RoomType).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.RoomTypeId)
                .HasConstraintName("FK_Rooms_RoomTypes");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.HasKey(e => e.RoomTypeId).HasName("PK_RoomTypes");

            entity.ToTable("RoomType");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RoomDetail)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ResignDate).HasColumnType("datetime");

            entity.HasOne(d => d.CityNavigation).WithMany(p => p.Staff)
                .HasForeignKey(d => d.City)
                .HasConstraintName("FK_Staff_Cities");

            entity.HasOne(d => d.Hotel).WithMany(p => p.Staff)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK_Staff_Hotel");

            entity.HasOne(d => d.Position).WithMany(p => p.Staff)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_Staff_Position");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
