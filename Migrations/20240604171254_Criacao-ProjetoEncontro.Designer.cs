﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoEncontro.Models;

#nullable disable

namespace ProjetoEncontro.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240604171254_Criacao-ProjetoEncontro")]
    partial class CriacaoProjetoEncontro
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoEncontro.Models.Animais", b =>
                {
                    b.Property<int>("AnimaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AnimaisId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimaisId"));

                    b.Property<string>("AnimalCor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalCor");

                    b.Property<DateTime>("AnimalDtDesaparecimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("AnimalDtDesaparecimento");

                    b.Property<DateTime?>("AnimalDtEncontro")
                        .HasColumnType("datetime2")
                        .HasColumnName("AnimalDtEncontro");

                    b.Property<string>("AnimalFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalFoto");

                    b.Property<string>("AnimalNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalNome");

                    b.Property<string>("AnimalObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalObservacao");

                    b.Property<string>("AnimalRaca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalRaca");

                    b.Property<string>("AnimalSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalSexo");

                    b.Property<byte>("AnimalStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("AnimalStatus");

                    b.Property<string>("AnimalTipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalTipo");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("AnimaisId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Animais");
                });

            modelBuilder.Entity("ProjetoEncontro.Models.Observacoes", b =>
                {
                    b.Property<int>("ObservacoesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ObservacoesId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObservacoesId"));

                    b.Property<int>("AnimaisId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ObservacoesData")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObservacoesData");

                    b.Property<string>("ObservacoesDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesDescricao");

                    b.Property<string>("ObservacoesLocal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesLocal");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ObservacoesId");

                    b.HasIndex("AnimaisId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Observacoes");
                });

            modelBuilder.Entity("ProjetoEncontro.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.Property<string>("UsuarioTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTelefone");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoEncontro.Models.Animais", b =>
                {
                    b.HasOne("ProjetoEncontro.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProjetoEncontro.Models.Observacoes", b =>
                {
                    b.HasOne("ProjetoEncontro.Models.Animais", "Animais")
                        .WithMany()
                        .HasForeignKey("AnimaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoEncontro.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animais");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
