using System.ComponentModel.DataAnnotations.Schema;

[Table("Commento")]
public class Commento
{
    public int Id {get; set;}
    public string Utente {get; set;} = null!;
    public string Testo {get; set;} = null!;
    public int postRif {get; set;}
}