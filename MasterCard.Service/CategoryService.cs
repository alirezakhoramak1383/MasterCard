using MasterCard.Data.Context;
using MasterCard.Domain.Cards;
using MasterCard.Model;

namespace MasterCard.Service
{
    //CategoryInterface
    public interface CategoryService
    {
        List<Category> Get();
        Category Get(int id);
        void CreateCategory(Category commend);
        void UpdateCategory(Category commend);
        bool DeleteCategory(int id);
        void Save();
    }
    public class CategoryRepository : CategoryService
    {
        private readonly MasterCardContext _masterCardContext;
        public CategoryRepository(MasterCardContext masterCardContext)
        {
            _masterCardContext = masterCardContext;
        }

        public List<Category> Get()
        {
            return _masterCardContext.Categories.ToList();
        }

        public Category Get(int id)
        {
            return _masterCardContext.Categories.FirstOrDefault(x => x.Id == id);
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