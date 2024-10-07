using MasterCard.Domain.Cards;

namespace MasterCard.Service
{
    //CategoryInterface
    public interface ICategoryRepository
    {
        void CreateCategory(Category commend);
        List<Category> GetAll();
        void Get(int id);
        void UpdateCategory(int id);
        void DeleteCategory(int id);
    }
}
