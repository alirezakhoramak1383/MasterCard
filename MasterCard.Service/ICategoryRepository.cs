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
        // Hello Worlds

        public void CreateCategory(Category commend)
        {
            _masterCardContext.Categories.Add(commend);
            Save();
        }

        public void DeleteCategory(int id)
        {
            
            var CategoryToDelete = _masterCardContext.Categories.FirstOrDefault(c => c.Id == id);
            if (CategoryToDelete != null)
            {
                CategoryToDelete.IsDeleted = true;
                _masterCardContext.SaveChanges();
            }
        }

        public Category Get(int id)
        {
            return _masterCardContext.Categories.FirstOrDefault(x => x.Id == id);
        }

        public List<Category> GetAll(bool filter)
        {
            return _masterCardContext.Categories.Where(c => c.IsDeleted == filter).ToList();
        }
        public void Save()
        {
            _masterCardContext.SaveChanges();
            
        }
            public void UpdateCategory(Category commend)
        {
          //var CategoryToUpdate = _masterCardContext.Categories.Get
          //  _masterCardContext.SaveChanges();
        }
    
    }

}
