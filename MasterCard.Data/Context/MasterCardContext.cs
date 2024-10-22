using MasterCard.Domain.Cards;
using MasterCard.Domain.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Title = "ریاست", IsDeleted = false },
                 new Category { Id = 2, Title = "معاونت آموزش", IsDeleted = false },
                 new Category { Id = 3, Title = "معاونت فرهنگی تربیتی", IsDeleted = false },
                 new Category { Id = 4, Title = "معاونت پژوهش", IsDeleted = false },
                 new Category { Id = 5, Title = "معاونت بین الملل", IsDeleted = false });
            modelBuilder.Entity<Card>().HasData(
                   new Card { Id = 1, Title = "سامانه اتوماسیون اداری نسخه 5", Description = "نسخه جدید (سازگار با مرورگرهای گوگل کروم و فایرفاکس)", Icon = "https://localhost:7143/images/SiteIcons/chargoon.png", Link = "http://office5.miu.ir", IsDeleted = false, CardCategoryId = 1 },
                   new Card { Id = 2, Title = "سامانه تغذیه", Description = "", Icon = "https://localhost:7143/images/SiteIcons/foodCourt.png", Link = "https://food.miu.ac.ir", IsDeleted = false, CardCategoryId = 1 },
                   new Card { Id = 3, Title = "سامانه رفاهی کارکنان", Description = "گردشگری، تسهیلات، هدایا و بیمه", Icon = "https://localhost:7143/images/SiteIcons/workers.png", Link = "http://irefah.miu.ir/", IsDeleted = false, CardCategoryId = 1 },
                   new Card { Id = 4, Title = "پست الکترونیک المصطفی", Description = "پست الکترونیک سازمانی المصطفی (مدیران، اساتید و کارکنان)", Icon = "https://localhost:7143/images/SiteIcons/electronic.png", Link = "https://mail.miu.ac.ir", IsDeleted = false, CardCategoryId = 1 }
                 );


            modelBuilder.ApplyConfiguration(new CardCategoryMapping());
            modelBuilder.ApplyConfiguration(new MasterCardMapping());


        } 
    }
}

