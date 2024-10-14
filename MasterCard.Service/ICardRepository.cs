using MasterCard.Data.Context;
using MasterCard.Domain.Cards;

namespace MasterCard.Service
{
    //CardInterface
    public interface ICardRepository
    {
        void Create(Card card);
        List<Card> GetAll();
        void Get(int id);
        void Update(int id);
        void Delete(int id);
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
            _masterCardContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Card> GetAll()
        {
            return _masterCardContext.Cards.ToList();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }

}
