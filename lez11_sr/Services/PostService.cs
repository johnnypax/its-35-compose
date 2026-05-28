public class PostService
{
    private readonly PostRepository _postRepository;
    private readonly CommentoService _commentoService;

    public PostService(PostRepository repo, CommentoService commentoService)
    {
        _postRepository = repo;
        _commentoService = commentoService;
    }

    public List<PostDTO> GetAll()
    {
        List<Post> lista = _postRepository.GetAll();
        List<PostDTO> risultato = new List<PostDTO>();

        foreach (Post p in lista)
        {
            risultato.Add(
                new PostDTO()
                {
                    Testo = p.Testo,
                    Titolo = p.Titolo,
                    Commenti = _commentoService.GetCommentiByPostId(p.Id)
                }
            );
        }

        return risultato;
    }

    public PostDTO? GetById(int id)
    {
        Post? p = _postRepository.GetById(id);
        if (p == null)
            return null;

        return new PostDTO()
        {
            Testo = p.Testo,
            Titolo = p.Titolo,
            Commenti = _commentoService.GetCommentiByPostId(p.Id)
        };
    }
}