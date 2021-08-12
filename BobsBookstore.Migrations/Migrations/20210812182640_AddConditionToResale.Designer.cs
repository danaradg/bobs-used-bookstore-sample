﻿// <auto-generated />
using System;
using BobsBookstore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BobsBookstore.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210812182640_AddConditionToResale")]
    partial class AddConditionToResale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BobsBookstore.Models.Books.Book", b =>
                {
                    b.Property<long>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AudioBookUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Genre_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeftUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Publisher_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("RightUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Type_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Book_Id");

                    b.HasIndex("Genre_Id");

                    b.HasIndex("Publisher_Id");

                    b.HasIndex("Type_Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.Condition", b =>
                {
                    b.Property<long>("Condition_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConditionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Condition_Id");

                    b.ToTable("Condition");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.Genre", b =>
                {
                    b.Property<long>("Genre_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Genre_Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.Price", b =>
                {
                    b.Property<long>("Price_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<long?>("Book_Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("Condition_Id")
                        .HasColumnType("bigint");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Price_Id");

                    b.HasIndex("Book_Id");

                    b.HasIndex("Condition_Id");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.Publisher", b =>
                {
                    b.Property<long>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.Resale", b =>
                {
                    b.Property<long>("Resale_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AudioBookUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BookPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Comment")
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("ConditionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FrontUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeftUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ResaleStatus_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("RightUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Resale_Id");

                    b.HasIndex("Customer_Id");

                    b.HasIndex("ResaleStatus_Id");

                    b.ToTable("Resale");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.ResaleStatus", b =>
                {
                    b.Property<long>("ResaleStatus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResaleStatus_Id");

                    b.ToTable("ResaleStatus");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.Type", b =>
                {
                    b.Property<long>("Type_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Type_Id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("BobsBookstore.Models.Carts.Cart", b =>
                {
                    b.Property<string>("Cart_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Customer_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cart_Id");

                    b.HasIndex("Customer_Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("BobsBookstore.Models.Carts.CartItem", b =>
                {
                    b.Property<string>("CartItem_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("Book_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Cart_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("Price_Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("WantToBuy")
                        .HasColumnType("bit");

                    b.HasKey("CartItem_Id");

                    b.HasIndex("Book_Id");

                    b.HasIndex("Cart_Id");

                    b.HasIndex("Price_Id");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("BobsBookstore.Models.Customers.Address", b =>
                {
                    b.Property<long>("Address_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Address_Id");

                    b.HasIndex("Customer_Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BobsBookstore.Models.Customers.Customer", b =>
                {
                    b.Property<string>("Customer_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("BobsBookstore.Models.Orders.Order", b =>
                {
                    b.Property<long>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Address_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Customer_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DeliveryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderStatus_Id")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("Rowversion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Order_Id");

                    b.HasIndex("Address_Id");

                    b.HasIndex("Customer_Id");

                    b.HasIndex("OrderStatus_Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BobsBookstore.Models.Orders.OrderDetail", b =>
                {
                    b.Property<long>("OrderDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Book_Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<decimal>("OrderDetailPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("Order_Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("Price_Id")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("OrderDetail_Id");

                    b.HasIndex("Book_Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Price_Id");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("BobsBookstore.Models.Orders.OrderStatus", b =>
                {
                    b.Property<long>("OrderStatus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderStatus_Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.Book", b =>
                {
                    b.HasOne("BobsBookstore.Models.Books.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("Genre_Id");

                    b.HasOne("BobsBookstore.Models.Books.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("Publisher_Id");

                    b.HasOne("BobsBookstore.Models.Books.Type", "Type")
                        .WithMany()
                        .HasForeignKey("Type_Id");

                    b.Navigation("Genre");

                    b.Navigation("Publisher");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.Price", b =>
                {
                    b.HasOne("BobsBookstore.Models.Books.Book", "Book")
                        .WithMany()
                        .HasForeignKey("Book_Id");

                    b.HasOne("BobsBookstore.Models.Books.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("Condition_Id");

                    b.Navigation("Book");

                    b.Navigation("Condition");
                });

            modelBuilder.Entity("BobsBookstore.Models.Books.Resale", b =>
                {
                    b.HasOne("BobsBookstore.Models.Customers.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_Id");

                    b.HasOne("BobsBookstore.Models.Books.ResaleStatus", "ResaleStatus")
                        .WithMany()
                        .HasForeignKey("ResaleStatus_Id");

                    b.Navigation("Customer");

                    b.Navigation("ResaleStatus");
                });

            modelBuilder.Entity("BobsBookstore.Models.Carts.Cart", b =>
                {
                    b.HasOne("BobsBookstore.Models.Customers.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_Id");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BobsBookstore.Models.Carts.CartItem", b =>
                {
                    b.HasOne("BobsBookstore.Models.Books.Book", "Book")
                        .WithMany()
                        .HasForeignKey("Book_Id");

                    b.HasOne("BobsBookstore.Models.Carts.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("Cart_Id");

                    b.HasOne("BobsBookstore.Models.Books.Price", "Price")
                        .WithMany()
                        .HasForeignKey("Price_Id");

                    b.Navigation("Book");

                    b.Navigation("Cart");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("BobsBookstore.Models.Customers.Address", b =>
                {
                    b.HasOne("BobsBookstore.Models.Customers.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_Id");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BobsBookstore.Models.Orders.Order", b =>
                {
                    b.HasOne("BobsBookstore.Models.Customers.Address", "Address")
                        .WithMany()
                        .HasForeignKey("Address_Id");

                    b.HasOne("BobsBookstore.Models.Customers.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_Id");

                    b.HasOne("BobsBookstore.Models.Orders.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatus_Id");

                    b.Navigation("Address");

                    b.Navigation("Customer");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("BobsBookstore.Models.Orders.OrderDetail", b =>
                {
                    b.HasOne("BobsBookstore.Models.Books.Book", "Book")
                        .WithMany()
                        .HasForeignKey("Book_Id");

                    b.HasOne("BobsBookstore.Models.Orders.Order", "Order")
                        .WithMany()
                        .HasForeignKey("Order_Id");

                    b.HasOne("BobsBookstore.Models.Books.Price", "Price")
                        .WithMany()
                        .HasForeignKey("Price_Id");

                    b.Navigation("Book");

                    b.Navigation("Order");

                    b.Navigation("Price");
                });
#pragma warning restore 612, 618
        }
    }
}
