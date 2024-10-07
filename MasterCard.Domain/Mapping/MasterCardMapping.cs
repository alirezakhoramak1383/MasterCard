using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MasterCard.Domain.Cards;

namespace MasterCard.Domain.Mapping
{
    public class MasterCardMapping : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("CadModels");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Icon).HasMaxLength(700).IsRequired();
            builder.Property(x => x.Link).HasMaxLength(700).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.Cards).HasForeignKey(x => x.CardCategoryId);

        }
    }
}
