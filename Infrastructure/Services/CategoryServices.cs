using Domain.Models;

namespace Infrastructure.Services;

public class CategoryServices
{
    public static List<Category> categorys = new List<Category>();
    public static void CreateCategory(Category category)
    {
        categorys.Add(category);
    }   
    public static List<Category> GetCategorys()
    {
        return categorys;
    }
    public static Category GetCategoryById(int id)
    {
        var cnt = categorys.FirstOrDefault(e => e.Id==id);
        return cnt;
    }
    public static Category GetCategoryByName(string name)
    {
        var cnt = categorys.FirstOrDefault(e => e.Name==name);
        return cnt;
    }
    public static List<Category> GetCategorysByDate(DateTime date)
    {
        var cnt = categorys.Where(e => e.CreatedAt==date).ToList();
        return cnt;
    } 
    public static List<Category> GetCategorysByCategoryId(int id)
    {
        var cnt = categorys.Where(e => e.Id==id).ToList();
        return cnt;
    }
    public static void DeleteCategory(int id)
    {
        var cnt = categorys.FirstOrDefault(e => e.Id==id);
        categorys.Remove(cnt);
    }   
}