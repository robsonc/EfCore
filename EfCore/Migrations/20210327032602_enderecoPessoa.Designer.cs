// <auto-generated />
using EfCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210327032602_enderecoPessoa")]
    partial class enderecoPessoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("EfCore.Data.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("EfCore.Data.Entities.Pessoa", b =>
                {
                    b.OwnsOne("EfCore.Data.Entities.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("PessoaId");

                            b1.Property<string>("Logradouro");

                            b1.HasKey("PessoaId");

                            b1.ToTable("Pessoas");

                            b1.HasOne("EfCore.Data.Entities.Pessoa")
                                .WithOne("Endereco")
                                .HasForeignKey("EfCore.Data.Entities.Endereco", "PessoaId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
