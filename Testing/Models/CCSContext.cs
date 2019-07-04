using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Testing.Models
{
    public partial class CCSContext : DbContext
    {
        public CCSContext()
        {
        }

        public CCSContext(DbContextOptions<CCSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ENADOC-PC010\\SANJE_DE;Initial Catalog=CCS;Persist Security Info=True;User ID=sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Customer")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LandNo).HasMaxLength(50);

                entity.Property(e => e.MobileNo1).HasMaxLength(50);

                entity.Property(e => e.MobileNo2).HasMaxLength(50);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Nic)
                    .HasColumnName("NIC")
                    .HasMaxLength(15);

                entity.Property(e => e.SendSms).HasColumnName("SendSMS");

                entity.Property(e => e.SetSmsforNo1).HasColumnName("SetSMSForNo1");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillNumber)
                    .IsRequired()
                    .HasColumnName("Bill_Number");

                entity.Property(e => e.CustomerName).HasColumnName("Customer_Name");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasColumnName("Pay_Type");

                entity.Property(e => e.TempBalance).HasColumnName("Temp_Balance");

                entity.Property(e => e.TotalAmount).HasColumnName("Total_Amount");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoNum).ValueGeneratedOnAdd();

                entity.Property(e => e.PasswordHash).HasColumnName("passwordHash");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
