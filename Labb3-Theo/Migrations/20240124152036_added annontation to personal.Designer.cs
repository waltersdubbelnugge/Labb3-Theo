﻿// <auto-generated />
using System;
using Labb3_Theo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb3_Theo.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    [Migration("20240124152036_added annontation to personal")]
    partial class addedannontationtopersonal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb3_Theo.Models.Betyg", b =>
                {
                    b.Property<int>("BetygsId")
                        .HasColumnType("int")
                        .HasColumnName("BetygsID");

                    b.Property<string>("Betyg1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Betyg");

                    b.Property<DateOnly?>("Datum")
                        .HasColumnType("date");

                    b.Property<int?>("KursId")
                        .HasColumnType("int")
                        .HasColumnName("KursID");

                    b.Property<int?>("LärarId")
                        .HasColumnType("int")
                        .HasColumnName("LärarID");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasKey("BetygsId")
                        .HasName("PK__Betyg__2DD1328FE537F38F");

                    b.HasIndex("KursId");

                    b.HasIndex("LärarId");

                    b.HasIndex("StudentId");

                    b.ToTable("Betyg", (string)null);
                });

            modelBuilder.Entity("Labb3_Theo.Models.Klass", b =>
                {
                    b.Property<int>("KlassId")
                        .HasColumnType("int")
                        .HasColumnName("KlassID");

                    b.Property<string>("Klassnamn")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("KlassId")
                        .HasName("PK__Klass__CF47A60D130FFF57");

                    b.ToTable("Klass", (string)null);
                });

            modelBuilder.Entity("Labb3_Theo.Models.Kur", b =>
                {
                    b.Property<int>("KursId")
                        .HasColumnType("int")
                        .HasColumnName("KursID");

                    b.Property<string>("Kursnamn")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("KursId")
                        .HasName("PK__Kurs__BCCFFF3BC51CDED4");

                    b.ToTable("Kurs");
                });

            modelBuilder.Entity("Labb3_Theo.Models.Lärare", b =>
                {
                    b.Property<int>("LärarId")
                        .HasColumnType("int")
                        .HasColumnName("LärarID");

                    b.Property<string>("Namn")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ämne")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("LärarId")
                        .HasName("PK__Lärare__AD685B6C680731F4");

                    b.ToTable("Lärare", (string)null);
                });

            modelBuilder.Entity("Labb3_Theo.Models.Personal", b =>
                {
                    b.Property<int>("PersonalId")
                        .HasColumnType("int")
                        .HasColumnName("PersonalID");

                    b.Property<string>("Befattning")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Namn")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("PersonalId")
                        .HasName("PK__Personal__28343713A8A7E4E1");

                    b.ToTable("Personal", (string)null);
                });

            modelBuilder.Entity("Labb3_Theo.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.Property<int?>("KlassId")
                        .HasColumnType("int")
                        .HasColumnName("KlassID");

                    b.Property<string>("Namn")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Personnummer")
                        .HasColumnType("int");

                    b.HasKey("StudentId")
                        .HasName("PK__Student__32C52A7951FD00C9");

                    b.HasIndex("KlassId");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("Labb3_Theo.Models.Betyg", b =>
                {
                    b.HasOne("Labb3_Theo.Models.Kur", "Kurs")
                        .WithMany("Betygs")
                        .HasForeignKey("KursId")
                        .HasConstraintName("FK__Betyg__KursID__4316F928");

                    b.HasOne("Labb3_Theo.Models.Lärare", "Lärar")
                        .WithMany("Betygs")
                        .HasForeignKey("LärarId")
                        .HasConstraintName("FK__Betyg__LärarID__440B1D61");

                    b.HasOne("Labb3_Theo.Models.Student", "Student")
                        .WithMany("Betygs")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__Betyg__StudentID__4222D4EF");

                    b.Navigation("Kurs");

                    b.Navigation("Lärar");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Labb3_Theo.Models.Lärare", b =>
                {
                    b.HasOne("Labb3_Theo.Models.Personal", "Lärar")
                        .WithOne("Lärare")
                        .HasForeignKey("Labb3_Theo.Models.Lärare", "LärarId")
                        .IsRequired()
                        .HasConstraintName("FK_Lärare_Personal");

                    b.Navigation("Lärar");
                });

            modelBuilder.Entity("Labb3_Theo.Models.Student", b =>
                {
                    b.HasOne("Labb3_Theo.Models.Klass", "Klass")
                        .WithMany("Students")
                        .HasForeignKey("KlassId")
                        .HasConstraintName("FK__Student__KlassID__3D5E1FD2");

                    b.Navigation("Klass");
                });

            modelBuilder.Entity("Labb3_Theo.Models.Klass", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Labb3_Theo.Models.Kur", b =>
                {
                    b.Navigation("Betygs");
                });

            modelBuilder.Entity("Labb3_Theo.Models.Lärare", b =>
                {
                    b.Navigation("Betygs");
                });

            modelBuilder.Entity("Labb3_Theo.Models.Personal", b =>
                {
                    b.Navigation("Lärare");
                });

            modelBuilder.Entity("Labb3_Theo.Models.Student", b =>
                {
                    b.Navigation("Betygs");
                });
#pragma warning restore 612, 618
        }
    }
}
