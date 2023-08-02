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
    [Migration("20230802152438_Atualizacao-Aluno01")]
    partial class AtualizacaoAluno01
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
                        .HasColumnType("integer")
                        .HasColumnName("Id");

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

                    b.Property<double>("CNPJ")
                        .HasColumnType("double precision")
                        .HasColumnName("CNPJ");

                    b.Property<double>("CPF")
                        .HasColumnType("double precision")
                        .HasColumnName("CPF");

                    b.Property<double?>("Celular")
                        .HasColumnType("double precision")
                        .HasColumnName("celular");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasColumnType("text")
                        .HasColumnName("complemento");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Data_do_Cadastro")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_do_cadastro");

                    b.Property<string>("DocResp")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DocResponsavel");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("EmailAddress");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<int>("Idade")
                        .HasColumnType("integer")
                        .HasColumnName("Idade");

                    b.Property<decimal>("Matricula")
                        .HasColumnType("numeric(20,0)")
                        .HasColumnName("Matricula");

                    b.Property<string>("NameInst")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Instituição");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.Property<string>("Observacao")
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Responsavel");

                    b.Property<int?>("StatusAluno")
                        .HasColumnType("integer")
                        .HasColumnName("StatusAluno");

                    b.Property<double?>("Telefone")
                        .HasColumnType("double precision")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("PWS.Models.Docentes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

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
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_do_cadastro");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<int>("Idade")
                        .HasColumnType("integer")
                        .HasColumnName("Idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.Property<string>("Observacao")
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.Property<double>("Salario")
                        .HasColumnType("double precision")
                        .HasColumnName("Salario");

                    b.Property<string>("Telefone")
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.HasKey("ID");

                    b.ToTable("Docentes");
                });

            modelBuilder.Entity("PWS.Models.Instituicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AlunosId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Bairro");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CEP");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cidade");

                    b.Property<string>("Complemento")
                        .HasColumnType("text")
                        .HasColumnName("Complemento");

                    b.Property<DateTime>("Data_do_Cadastro")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_do_cadastro");

                    b.Property<int?>("DocentesID")
                        .HasColumnType("integer");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Endereco");

                    b.Property<string>("NomeInstituicao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Responsavel");

                    b.Property<double?>("Telefone")
                        .HasColumnType("double precision")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("AlunosId");

                    b.HasIndex("DocentesID");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("PWS.Models.Instituicao", b =>
                {
                    b.HasOne("PWS.Models.Alunos", null)
                        .WithMany("Instituicao")
                        .HasForeignKey("AlunosId");

                    b.HasOne("PWS.Models.Docentes", null)
                        .WithMany("Instituicao")
                        .HasForeignKey("DocentesID");
                });

            modelBuilder.Entity("PWS.Models.Alunos", b =>
                {
                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("PWS.Models.Docentes", b =>
                {
                    b.Navigation("Instituicao");
                });
#pragma warning restore 612, 618
        }
    }
}
