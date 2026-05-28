public class PostDTO
{
    public string Titolo {get; set;} = null!;
    public string? Testo {get; set;}
    public List<CommentoDTO> Commenti {get; set;} = new List<CommentoDTO>();
}