using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
            public void Configure(EntityTypeBuilder<Cliente> builder)
            {
                builder.ToTable("Cliente");

                builder.HasKey(c => c.Id);


                builder.Property(c => c.rgCliente)
                    .IsRequired()
                    .HasColumnName("RG");

                builder.Property(c => c.enderecoCliente)
                    .IsRequired()
                    .HasColumnName("Endereco");

                builder.Property(c => c.nomeCliente)
                    .IsRequired()
                    .HasColumnName("Nome");

                builder.Property(c => c.rgCliente)
                    .IsRequired()
                    .HasColumnName("RG");

                builder.Property(c => c.bairroCliente)
                    .IsRequired()
                    .HasColumnName("Bairro");

                builder.Property(c => c.cidadeCliente)
                    .IsRequired()
                    .HasColumnName("Cidade");

                builder.Property(c => c.estadoCLiente)
                    .IsRequired()
                    .HasColumnName("Estado");

                builder.Property(c => c.CEPCLiente)
                    .IsRequired()
                    .HasColumnName("CEP");

                builder.Property(c => c.CEPCLiente)
                     .IsRequired()
                     .HasColumnName("CEP");

                builder.Property(c => c.nascimentoCLiente)
                     .IsRequired()
                     .HasColumnName("Nascimento");

            }
        }

}
