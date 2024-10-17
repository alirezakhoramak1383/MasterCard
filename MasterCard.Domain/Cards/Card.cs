using System.ComponentModel.DataAnnotations;

namespace MasterCard.Domain.Cards
{
    public class Card
    {
        [Key]
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public string Link { get; set; }

        public bool IsDeleted { get; set; }

        public long CardCategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Card(long id=1, string title="سامانه هوایی", string description= "برای رفت و آمد هواپیما", string icon= "https://localhost:7143/images/SiteIcons/foodCourt.png", string link= "https://www.google.com")
        {
            Id = id;
            Title = title;
            Description = description;
            Icon = icon;
            Link = link;
            IsDeleted = false;
        }
        //public void Edit(string title, string description, string icon, string link)
        //{
        //    Title = title;  
        //    Description = description;
        //    Icon = icon;
        //    Link = link;
        //    IsDeleted = false;
        //}
        //public void Delete() 
        //{
        //    IsDeleted = true;
        //}
        //public void Restore()
        //{
        //    IsDeleted = false;
        //}
    }
}
