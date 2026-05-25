public class PostService
{
    private readonly PostRepository _postRepository;

    public PostService(PostRepository repo)
    {
        _postRepository = repo;
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
                    Titolo = p.Titolo
                }
            );
        }

        return risultato;
    }
}