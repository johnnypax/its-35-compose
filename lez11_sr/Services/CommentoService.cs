public class CommentoService
{
    private readonly CommentoRepository _commentoRepository;
    public CommentoService(CommentoRepository repo)
    {
        _commentoRepository = repo;
    }

    public List<CommentoDTO> GetCommentiByPostId(int postId)
    {
        List<Commento> lista = _commentoRepository.GetByPostId(postId);
        List<CommentoDTO> risultato = new List<CommentoDTO>();

        foreach (Commento c in lista)
        {
            risultato.Add(
                new CommentoDTO()
                {
                    Testo = c.Testo,
                    Utente = c.Utente
                }
            );
        }

        return risultato;
    }

}