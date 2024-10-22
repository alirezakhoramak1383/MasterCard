using MasterCard.Data.Context;
using MasterCard.Domain.Cards;
using MasterCard.Model;

namespace MasterCard.Service
{
    //CardInterface
    public interface CardService
    {
        List<Card> Get();
        Card Get(int id);
        void Create(Card card);
        List<CardViewModel> Search(string Command);
        void Update(Card command);
        bool Delete(int id);
        bool Restore(int id);
        void Save();
    }

    public class CardRepository : CardService
    {
        private readonly MasterCardContext _masterCardContext;

        public CardRepository(MasterCardContext masterCardContext)
        {
            _masterCardContext = masterCardContext;
        }
        public List<Card> Get()
        {
            return _masterCardContext.Cards.ToList();
        }

        public Card Get(int id)
        {
            return _masterCardContext.Cards.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Card card)
        {
            var cardModel = new Card()
            {
                Id = card.Id,
                Description = card.Description,
                Icon = card.Icon,
                Title = card.Title,
                Link = card.Link,
                IsDeleted = false,
            };
            _masterCardContext.Cards.Add(cardModel);
            Save();
        }

        public void Update(Card command)
        {
            var cardModel=_masterCardContext.Cards.FirstOrDefault(x=>x.Id == command.Id);
            if (cardModel != null) 
            {
                cardModel.Description = command.Description;
                cardModel.Icon = command.Icon;  
                cardModel.Title = command.Title;    
                cardModel.Link=cardModel.Link;
            }
            Save();
        }


        public bool Delete(int id)
        {
            var cardModel = _masterCardContext.Cards.FirstOrDefault(x => x.Id == id);
            cardModel.IsDeleted = true;
            return true;
        }

        public bool Restore(int id)
        {
            var cardModel = _masterCardContext.Cards.FirstOrDefault(x => x.Id == id);
            if(cardModel != null)
            {
                cardModel.IsDeleted= false;
            }
            
            return true;
        }


        public void Save()
        {
            _masterCardContext.SaveChanges();
        }

        public List<CardViewModel> Search(string Command)
        {
            var query = _masterCardContext.Cards.Select(x => new CardViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Icon = x.Icon,
                Link = x.Link,
               

            });
            if (!string.IsNullOrWhiteSpace(Command))
                query = query.Where(x => x.Title.Contains(Command));

            return query.OrderByDescending(x => x.Id).ToList();
        }

      
    }
}
