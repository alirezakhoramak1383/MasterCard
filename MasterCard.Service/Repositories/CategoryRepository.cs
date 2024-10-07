using MasterCard.Data.Context;
using MasterCard.Domain.Cards;

namespace MasterCard.Service.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly MasterCardContext _masterCardContext;

    public CategoryRepository(MasterCardContext masterCardContext)
    {
        _masterCardContext = masterCardContext;
    }

    public void CreateCategory(Category commend)
    {
        var Categories = new Category()
        {
            Id = commend.Id,
            Title = commend.Title,
            Cards = commend.Cards,
        };
        _masterCardContext.Categories.Add(Categories);
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

    public void UpdateCategory(string commend)
    {
        throw new NotImplementedException();
    }
}
