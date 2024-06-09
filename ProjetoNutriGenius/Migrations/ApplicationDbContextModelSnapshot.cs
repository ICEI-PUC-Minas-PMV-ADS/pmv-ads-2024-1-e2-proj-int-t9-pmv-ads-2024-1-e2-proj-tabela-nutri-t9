﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProjetoNutriGenius.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MateriaPrimaModel", b =>
                {
                    b.Property<string>("NomeMateriaPrima")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome_materia_prima");

                    b.Property<float?>("AcucaresAdicionados")
                        .HasColumnType("float")
                        .HasColumnName("acucares_adicionados");

                    b.Property<float?>("AcucaresTotais")
                        .HasColumnType("float")
                        .HasColumnName("acucares_totais");

                    b.Property<float?>("Carboidratos")
                        .HasColumnType("float")
                        .HasColumnName("carboidratos");

                    b.Property<float?>("FibraAlimentar")
                        .HasColumnType("float")
                        .HasColumnName("fibra_alimentar");

                    b.Property<float?>("GordurasSaturadas")
                        .HasColumnType("float")
                        .HasColumnName("gorduras_saturadas");

                    b.Property<float?>("GordurasTotais")
                        .HasColumnType("float")
                        .HasColumnName("gorduras_totais");

                    b.Property<float?>("GordurasTrans")
                        .HasColumnType("float")
                        .HasColumnName("gorduras_trans");

                    b.Property<float?>("Proteinas")
                        .HasColumnType("float")
                        .HasColumnName("proteinas");

                    b.Property<int?>("Sodio")
                        .HasColumnType("int")
                        .HasColumnName("sodio");

                    b.Property<int?>("ValorEnergetico")
                        .HasColumnType("int")
                        .HasColumnName("valor_energetico");

                    b.HasKey("NomeMateriaPrima");

                    b.ToTable("materia_prima", (string)null);
                });

            modelBuilder.Entity("ProdutoMateriaPrimaModel", b =>
                {
                    b.Property<string>("NomeMateriaPrima")
                        .HasColumnType("varchar(255)");

                    b.Property<double?>("Quantidade")
                        .HasColumnType("double")
                        .HasColumnName("quantidade");

                    b.HasKey("NomeMateriaPrima");

                    b.ToTable("produto_materia_prima", (string)null);
                });

            modelBuilder.Entity("ProdutoModel", b =>
                {
                    b.Property<string>("NomeProduto")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome_produto");

                    b.Property<int?>("CodigoProduto")
                        .HasColumnType("int")
                        .HasColumnName("codigo_produto");

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("NomeProduto");

                    b.HasIndex("UsuarioEmail");

                    b.ToTable("produto", (string)null);
                });

            modelBuilder.Entity("UsuarioModel", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .HasColumnType("longtext")
                        .HasColumnName("cep");

                    b.Property<string>("CNPJ")
                        .HasColumnType("longtext")
                        .HasColumnName("cnpj");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext")
                        .HasColumnName("celular");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext")
                        .HasColumnName("cidade");

                    b.Property<string>("ConfirmeSenha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("confirme_senha");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext")
                        .HasColumnName("estado");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome_completo");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext")
                        .HasColumnName("numero");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("longtext")
                        .HasColumnName("razao_social");

                    b.Property<string>("Rua")
                        .HasColumnType("longtext")
                        .HasColumnName("rua");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.HasKey("Email");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("ProdutoMateriaPrimaModel", b =>
                {
                    b.HasOne("MateriaPrimaModel", "MateriaPrima")
                        .WithMany("ProdutoMateriaPrima")
                        .HasForeignKey("NomeMateriaPrima")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MateriaPrima");
                });

            modelBuilder.Entity("ProdutoModel", b =>
                {
                    b.HasOne("ProdutoMateriaPrimaModel", "ProdutoMateriaPrima")
                        .WithOne("Produto")
                        .HasForeignKey("ProdutoModel", "NomeProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProdutoMateriaPrima");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MateriaPrimaModel", b =>
                {
                    b.Navigation("ProdutoMateriaPrima");
                });

            modelBuilder.Entity("ProdutoMateriaPrimaModel", b =>
                {
                    b.Navigation("Produto")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
