using Domain.Models;

namespace Infrastructure.Services;

public class PostServices
{
    public static List<Post> posts = new List<Post>();
    public static void CreatePost(Post post)
    {
        posts.Add(post);
    }   
    public static List<Post> GetPosts()
    {
        return posts;
    }
    public static Post GetPostById(int id)
    {
        var cnt = posts.FirstOrDefault(e => e.Id==id);
        return cnt;
    }
    public static Post GetPostByName(string name)
    {
        var cnt = posts.FirstOrDefault(e => e.Title==name);
        return cnt;
    }
    public static List<Post> GetPostsByDate(DateTime date)
    {
        var cnt = posts.Where(e => e.CreatedAt==date).ToList();
        return cnt;
    } 
    public static List<Post> GetPostsByCategoryId(int id)
    {
        var cnt = posts.Where(e => e.Id==id).ToList();
        return cnt;
    }
    public static void DeletePost(int id)
    {
        var cnt = posts.FirstOrDefault(e => e.Id==id);
        posts.Remove(cnt);
    }
}