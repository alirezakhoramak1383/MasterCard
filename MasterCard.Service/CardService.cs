using MasterCard.Data.Context;
using MasterCard.Domain.Cards;

namespace MasterCard.Service
{
    //CardInterface
    public interface CardService
    {
        List<Card> Get();
        Card Get(int id);
        void Create(Card card);
        void Update(int id);
        void Delete(int id);
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
            _masterCardContext.Cards.Add(card);
            Save();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }



        public void Save()
        {
            _masterCardContext.SaveChanges();
        }

    }
}
