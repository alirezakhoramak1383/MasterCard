using MasterCard.Data.Context;
using MasterCard.Domain.Cards;

namespace MasterCard.Service
{
    //CardInterface
    public interface ICardRepository
    {
        void Create(Card card);
        List<Card> GetAll();
        Card Get(int id);
        void Update(int id);
        void Delete(int id);
        void Save();
    }

    public class CardRepository : ICardRepository
    {
        private readonly MasterCardContext _masterCardContext;

        public CardRepository(MasterCardContext masterCardContext)
        {
            _masterCardContext = masterCardContext;
        }
        public void Create(Card card)
        {
            _masterCardContext.Cards.Add(card);
            Save();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Card Get(int id)
        {
           return _masterCardContext.Cards.FirstOrDefault(x=>x.Id==id);
        }

        public List<Card> GetAll()
        {
            return _masterCardContext.Cards.ToList();
        }

        public void Save()
        {
            _masterCardContext.SaveChanges();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }

}
