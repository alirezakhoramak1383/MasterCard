using MasterCard.Data.Context;
using MasterCard.Domain.Cards;

namespace MasterCard.Service
{
    //CategoryInterface
    public interface ICategoryRepository
    {
        void CreateCategory(Category commend);
        List<Category> GetAll();
        void Get(int id);
        void UpdateCategory(Category commnd);
        void DeleteCategory(int id);
    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MasterCardContext _masterCardContext;

        public CategoryRepository(MasterCardContext masterCardContext)
        {
            _masterCardContext = masterCardContext;
        }
        // Hello Worlds

        public void CreateCategory(Category commend)
        {
            _masterCardContext.Categories.Add(commend);
            _masterCardContext.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _masterCardContext.Categories.ToList();
        }

        public void UpdateCategory(Category commend)
        {
            throw new NotImplementedException();
        }
    }

}
