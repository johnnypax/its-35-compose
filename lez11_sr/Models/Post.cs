using System.ComponentModel.DataAnnotations.Schema;

[Table("Post")]
public class Post
{
    public int Id {get; set;}
    public string Titolo {get; set;} = null!;
    public string? Testo {get; set;}
}