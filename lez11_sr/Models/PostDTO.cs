public class PostDTO
{
    public string Titolo {get; set;} = null!;
    public string? Testo {get; set;}
    public List<CommentoDTO> commenti = new List<CommentoDTO>();
}