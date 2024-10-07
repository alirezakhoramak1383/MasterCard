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
   
}
