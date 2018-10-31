﻿// <auto-generated />
using System;
using CampanhaInfopharma.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CampanhaInfopharma.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20181031010328_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CampanhaInfopharma.Models.ContatoDrogaria", b =>
                {
                    b.Property<int>("DrogariaIdFk");

                    b.Property<DateTime>("DataUltimaAlteracao");

                    b.Property<int>("FuncionarioIdFk")
                        .HasColumnName("FuncionarioIdFk");

                    b.Property<string>("Observacao");

                    b.Property<int>("Status");

                    b.HasKey("DrogariaIdFk");

                    b.HasIndex("FuncionarioIdFk");

                    b.ToTable("ContatoDrogaria");
                });

            modelBuilder.Entity("CampanhaInfopharma.Models.Drogaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18);

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<string>("NomeFantasia")
                        .IsRequired();

                    b.Property<string>("NomeResponsavel");

                    b.Property<string>("RazaoSocial")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Drogaria");
                });

            modelBuilder.Entity("CampanhaInfopharma.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorMarcacao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("CampanhaInfopharma.Models.ContatoDrogaria", b =>
                {
                    b.HasOne("CampanhaInfopharma.Models.Drogaria", "Drogaria")
                        .WithOne("ContatoDrogaria")
                        .HasForeignKey("CampanhaInfopharma.Models.ContatoDrogaria", "DrogariaIdFk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CampanhaInfopharma.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioIdFk")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
