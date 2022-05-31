﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketSystem.Models;

#nullable disable

namespace TicketSystem.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("T_Role_Permission", b =>
                {
                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.HasKey("RoleID", "Permission");

                    b.HasIndex("Permission");

                    b.ToTable("T_Role_Permission", (string)null);
                });

            modelBuilder.Entity("T_User_Role", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("UserID", "RoleID");

                    b.HasIndex("RoleID");

                    b.ToTable("T_User_Role", (string)null);
                });

            modelBuilder.Entity("TicketSystem.Models.T_Parameter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("T_Parameter", (string)null);
                });

            modelBuilder.Entity("TicketSystem.Models.T_Permission", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Controller")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("T_Permission", (string)null);
                });

            modelBuilder.Entity("TicketSystem.Models.T_Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("T_Role", (string)null);
                });

            modelBuilder.Entity("TicketSystem.Models.T_Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Priority")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Resolved")
                        .HasColumnType("bit");

                    b.Property<string>("Severity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("T_Ticket", (string)null);
                });

            modelBuilder.Entity("TicketSystem.Models.T_User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("ID");

                    b.ToTable("T_User", (string)null);
                });

            modelBuilder.Entity("T_Role_Permission", b =>
                {
                    b.HasOne("TicketSystem.Models.T_Permission", null)
                        .WithMany()
                        .HasForeignKey("Permission")
                        .IsRequired()
                        .HasConstraintName("FK_T_Role_Permission_T_Permission");

                    b.HasOne("TicketSystem.Models.T_Role", null)
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .IsRequired()
                        .HasConstraintName("FK_T_Role_Permission_T_Role");
                });

            modelBuilder.Entity("T_User_Role", b =>
                {
                    b.HasOne("TicketSystem.Models.T_Role", null)
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .IsRequired()
                        .HasConstraintName("FK_T_User_Role_T_Role");

                    b.HasOne("TicketSystem.Models.T_User", null)
                        .WithMany()
                        .HasForeignKey("UserID")
                        .IsRequired()
                        .HasConstraintName("FK_T_User_Role_T_User");
                });
#pragma warning restore 612, 618
        }
    }
}
