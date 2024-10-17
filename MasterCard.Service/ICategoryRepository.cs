using MasterCard.Data.Context;
using MasterCard.Domain.Cards;
using MasterCard.Model;

namespace MasterCard.Service
{
    //CategoryInterface
    public interface ICategoryRepository
    {
        void CreateCategory(Category commend);
        List<Category> GetAll();
        Category Get(int id);
        void UpdateCategory(Category commend);
        bool DeleteCategory(int id);
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
            var category = new Category()
            {
                Id = commend.Id,
                Title = commend.Title,
                IsDeleted = false,
                Cards= commend.Cards,
            };
        _masterCardContext.Categories.Add(category);
         Save();
        }

        public bool DeleteCategory(int id)
        {
            var query = _masterCardContext.Categories.Any(x=>x.IsDeleted==false);
            return query;
        }

        public Category Get(int id)
        {
            return _masterCardContext.Categories.FirstOrDefault(x => x.Id == id);
        }

        public List<Category> GetAll()
        {
           return _masterCardContext.Categories.Where(x=>x.IsDeleted==false).ToList();
        }

        public void Save()
        {
            _masterCardContext.SaveChanges();
        }

        public void UpdateCategory(Category commend)
        {
            var category = _masterCardContext.Categories.Where(x=>x.IsDeleted==false).FirstOrDefault(x=>x.Id==commend.Id);
            if (category == null) return ;
            category.Title = commend.Title;
            Save();
        }
    
    }

}
