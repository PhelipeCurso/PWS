﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PWS.Models;

#nullable disable

namespace PWS.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230714204802_Docentes-Atualizacao")]
    partial class DocentesAtualizacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PWS.Models.Alunos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cep");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cpf");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("celular");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("complemento");

                    b.Property<DateTime>("Data_do_Cadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_do_cadastro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<int>("Idade")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("PWS.Models.Docentes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Bairro")
                        .HasColumnType("text")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .HasColumnType("text")
                        .HasColumnName("cep");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<string>("CPF")
                        .HasColumnType("text")
                        .HasColumnName("cpf");

                    b.Property<string>("Celular")
                        .HasColumnType("text")
                        .HasColumnName("celular");

                    b.Property<string>("Cidade")
                        .HasColumnType("text")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasColumnType("text")
                        .HasColumnName("complemento");

                    b.Property<DateTime>("Data_do_Cadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_do_cadastro");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Endereco")
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<int>("Idade")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Observacao")
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.Property<string>("Telefone")
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("Docentes");
                });
#pragma warning restore 612, 618
        }
    }
}