﻿// <auto-generated />
using System;
using APIExemplo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIExemplo.Migrations
{
    [DbContext(typeof(ExemploContext))]
    [Migration("20231023210937_aula13")]
    partial class aula13
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APIExemplo.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("APIExemplo.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("APIExemplo.Models.VendaProduto", b =>
                {
                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("VendaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("VendaProdutos");
                });

            modelBuilder.Entity("APIExemplo.Models.VendaProduto", b =>
                {
                    b.HasOne("APIExemplo.Models.Produto", "Produto")
                        .WithMany("VendaProdutos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIExemplo.Models.Venda", "Venda")
                        .WithMany("VendaProdutos")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("APIExemplo.Models.Produto", b =>
                {
                    b.Navigation("VendaProdutos");
                });

            modelBuilder.Entity("APIExemplo.Models.Venda", b =>
                {
                    b.Navigation("VendaProdutos");
                });
#pragma warning restore 612, 618
        }
    }
}
