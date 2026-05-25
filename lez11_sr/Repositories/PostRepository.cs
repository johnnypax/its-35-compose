public class PostRepository : IRepository<Post>
{
    private readonly BlogContext _context;

    public PostRepository(BlogContext context)
    {
        this._context = context;
    }
    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Post> GetAll()
    {
        return _context.Posts.ToList();
    }

    public Post? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Insert(Post obj)
    {
        throw new NotImplementedException();
    }

    public bool Update(Post obj)
    {
        throw new NotImplementedException();
    }
}