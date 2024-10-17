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
            _masterCardContext.Categories.Add(commend);
            Save();
        }

        public void UpdateCategory(Category commend)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }


        public void Save()
        {
            _masterCardContext.SaveChanges();
        }



    }

}