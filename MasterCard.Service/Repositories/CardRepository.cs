using MasterCard.Data.Context;
using MasterCard.Domain.Cards;

namespace MasterCard.Service.Repository
{
    public class CardRepository : ICardRepository
    {
        private readonly MasterCardContext _masterCardContext;

        public CardRepository(MasterCardContext masterCardContext)
        {
            _masterCardContext = masterCardContext;
        }
        public void Create(Card card)
        {
            throw new NotImplementedException();
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

