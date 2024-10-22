namespace MasterCard.Domain.Cards
{
    public class Card
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public string Link { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive {  get; set; }

        public long CardCategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
