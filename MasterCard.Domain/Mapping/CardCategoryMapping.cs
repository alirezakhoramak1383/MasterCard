using MasterCard.Domain.Cards;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterCard.Domain.Mapping
{
    // CardCategoeryMapping
    public class CardCategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("CardCategories");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(255).IsRequired();
            builder.HasMany(x => x.Cards).WithOne(x => x.Category).HasForeignKey(x => x.CardCategoryId);
        }
    }


}
