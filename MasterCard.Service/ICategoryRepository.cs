using MasterCard.Data.Context;
using MasterCard.Domain.Cards;

namespace MasterCard.Service
{
    //CategoryInterface
    public interface ICategoryRepository
    {
        void CreateCategory(Category commend);
        List<Category> GetAll();
        Category Get(int id);
        void UpdateCategory(Category commend);
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
        
        public void CreateCategory(Category commend)
        {
            _masterCardContext.Categories.Add(commend);
            Save();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            return _masterCardContext.Categories.FirstOrDefault(x => x.Id == id);
        }

        public List<Category> GetAll()
        {
           return _masterCardContext.Categories.ToList();
        }

        public void Save()
        {
            _masterCardContext.SaveChanges();
        }

        public void UpdateCategory(Category commend)
        {
            throw new NotImplementedException();
        }
    
    }

}
