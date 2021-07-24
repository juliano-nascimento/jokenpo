﻿// <auto-generated />
using Jokenpo.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jokenpo.API.Migrations
{
    [DbContext(typeof(JokenpoContext))]
    [Migration("20210724144445_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Jokenpo.API.Entities.Ranking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DscEscolhaJogador")
                        .HasColumnType("TEXT");

                    b.Property<string>("DscEscolhaMaquina")
                        .HasColumnType("TEXT");

                    b.Property<int>("EscolhaJogador")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EscolhaMaquina")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Vencedor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Rankings");
                });
#pragma warning restore 612, 618
        }
    }
}
