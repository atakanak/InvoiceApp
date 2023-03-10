// <auto-generated />
using System;
using InvoiceApp.API.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvoiceApp.API.Migrations
{
    [DbContext(typeof(InvoiceAppDBContext))]
    [Migration("20230301185646_update4")]
    partial class update4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("InvoiceApp.API.Model.InvoiceHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReceiverTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("InvoicesHeaders");
                });

            modelBuilder.Entity("InvoiceApp.API.Model.InvoiceLine", b =>
                {
                    b.Property<int>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvoiceHeaderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvoiceLineId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UnitCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineId");

                    b.HasIndex("InvoiceHeaderId");

                    b.ToTable("InvoicesLines");
                });

            modelBuilder.Entity("InvoiceApp.API.Model.InvoiceLine", b =>
                {
                    b.HasOne("InvoiceApp.API.Model.InvoiceHeader", null)
                        .WithMany("InvoiceLine")
                        .HasForeignKey("InvoiceHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InvoiceApp.API.Model.InvoiceHeader", b =>
                {
                    b.Navigation("InvoiceLine");
                });
#pragma warning restore 612, 618
        }
    }
}
