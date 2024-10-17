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
            base.OnModelCreating(modelBuilder);

            if (Categories == null)
            {
                modelBuilder.Entity<Category>().HasData(
                     new Category { Title = "ریاست", IsDeleted = false },
                     new Category { Title = "معاونت آموزش", IsDeleted = false },
                     new Category { Title = "معاونت فرهنگی تربیتی", IsDeleted = false },
                     new Category { Title = "معاونت پژوهش", IsDeleted = false },
                     new Category { Title = "معاونت بین الملل", IsDeleted = false });
            }
            if (Cards == null)
            {
                modelBuilder.Entity<Card>().HasData(
                       new Card { Title = "سامانه اتوماسیون اداری نسخه 5", Description = "نسخه جدید (سازگار با مرورگرهای گوگل کروم و فایرفاکس)", Icon = "https://localhost:7143/images/SiteIcons/chargoon.png", Link = "http://office5.miu.ir", IsDeleted = false, CardCategoryId = 1 },
                       new Card { Title = "سامانه تغذیه", Description = "", Icon = "https://localhost:7143/images/SiteIcons/foodCourt.png", Link = "https://food.miu.ac.ir", IsDeleted = false, CardCategoryId = 1 },
                       new Card  { Title = "سامانه رفاهی کارکنان", Description = "گردشگری، تسهیلات، هدایا و بیمه", Icon = "https://localhost:7143/images/SiteIcons/workers.png", Link = "http://irefah.miu.ir/", IsDeleted = false, CardCategoryId = 1 },
                       new Card { Title = "پست الکترونیک المصطفی", Description = "پست الکترونیک سازمانی المصطفی (مدیران، اساتید و کارکنان)", Icon = "https://localhost:7143/images/SiteIcons/electronic.png", Link = "https://mail.miu.ac.ir", IsDeleted = false, CardCategoryId = 1 }
                     );
            }



            // Command To Add These Data👇
            // dotnet ef migrations add YourMigrationName
            modelBuilder.ApplyConfiguration(new CardCategoryMapping());
            modelBuilder.ApplyConfiguration(new MasterCardMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}

