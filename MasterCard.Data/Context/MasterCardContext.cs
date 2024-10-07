using MasterCard.Domain.Cards;
using MasterCard.Domain.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MasterCard.Data.Context
{
    public class MasterCardContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Card> Cards { get; set; }
        public MasterCardContext(DbContextOptions<MasterCardContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardCategoryMapping());
            modelBuilder.ApplyConfiguration(new MasterCardMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}

