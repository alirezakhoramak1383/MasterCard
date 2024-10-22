using MasterCard.Data.Context;
using MasterCard.Domain.Cards;

namespace MasterCard.Service
{
    //CategoryInterface
    public interface CategoryService
    {
        List<Category> Get();
        Category Get(int id);
        void CreateCategory(Category commend);
        void UpdateCategory(Category commend);
        void DeleteCategory(int id);
        void Save();
    }
    public class CategoryRepository : CategoryService
    {
        private readonly MasterCardContext _masterCardContext;
        public CategoryRepository(MasterCardContext masterCardContext)
        {
            _masterCardContext = masterCardContext;
        }

        //implement
        public List<Category> Get()
        {
            return _masterCardContext.Categories.ToList();
        }

        public Category Get(int id)
        {
            return _masterCardContext.Categories.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
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

        public void DeleteCategory(int id)
        {
            var category = _masterCardContext.Categories.Find(id);
            if (category != null)
            {
                category.IsDeleted = true;
                Save();
            }
        }
        public void Save()
        {
            _masterCardContext.SaveChanges();
        }

        public void UpdateCategory(Category commend)
        {
            var cardModel = _masterCardContext.Categories.Find(commend.Id);
            if (cardModel != null && !cardModel.IsDeleted)
            {
              cardModel.Title = commend.Title;
            }
            Save();
        }

    }

}