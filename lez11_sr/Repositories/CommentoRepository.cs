public class CommentoRepository : IRepository<Commento>
{
    private readonly BlogContext _context;

    public CommentoRepository(BlogContext context)
    {
        this._context = context;
    }
    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Commento> GetAll()
    {
        return _context.Commenti.ToList();
    }

    public Commento? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Insert(Commento obj)
    {
        throw new NotImplementedException();
    }

    public bool Update(Commento obj)
    {
        throw new NotImplementedException();
    }
}