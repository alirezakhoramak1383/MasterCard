﻿namespace MasterCard.Domain.Cards
{
    public class Category
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public bool IsDeleted { get; set; }

        public virtual List<Card> Cards { get; set; }
        public Category(string title)
        {
            Title = title;
            IsDeleted = false;
            Cards = new List<Card>();   
        }
    }

    
}
