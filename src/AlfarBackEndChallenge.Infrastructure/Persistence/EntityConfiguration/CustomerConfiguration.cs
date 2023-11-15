using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using AlfarBackEndChallenge.Domain.Entities;

namespace AlfarBackEndChallenge.Infrastructure.Persistence.EntityConfiguration
{
       public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
       {
              public void Configure(EntityTypeBuilder<Customer> builder)
              {
                     builder.ToTable("Customers");
                     builder.HasKey(c => c.Code);
                     builder.Property(c => c.Name)
                            .IsRequired()
                            .HasMaxLength(255);
                     builder.Property(c => c.Phone)
                            .HasMaxLength(20);
                     builder.Property(c => c.Email)
                            .IsRequired()
                            .HasMaxLength(255);
                     builder.Property(c => c.DateOfBirth)
                            .IsRequired();
                     builder.Property(c => c.Status)
                            .IsRequired();
                     builder.Property(c => c.DateCreated)
                            .IsRequired();
                     builder.Property(c => c.LastUpdated)
                            .IsRequired();
              }
       }
}
