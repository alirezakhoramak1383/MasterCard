using MasterCard.Data.Context;
using MasterCard.Domain.Cards;

namespace MasterCard.Service
{
    //CategoryInterface
    public interface ICategoryRepository
    {
        void CreateCategory(Category command);
        List<Category> GetAll();
        Category Get(int id);
        void UpdateCategory(Category command);
        void DeleteCategory(int id);
        void Save();
    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MasterCardContext _masterCardContext;

        public CategoryRepository(MasterCardContext masterCardContext)
        {
            _masterCardContext = masterCardContext;
        }

        public void CreateCategory(Category command)
        {
            _masterCardContext.Categories.Add(command);
            Save();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _masterCardContext.Categories.ToList();
        }

        public void Save()
        {
            _masterCardContext.SaveChanges();
        }

        public void UpdateCategory(Category command)
        {
            throw new NotImplementedException();
        }
    }

}
