namespace Academia;

public class Aluno
{
    public int Id {get; set;}
    public string Nome {get; set;} = string.Empty;
    public DateTime DataNascimento {get; set;}
    public string? UserId {get; set;}
    public List<Matricula> Matriculas {get; set;} = new();
    public List<AvaliacaoFisica> Avaliacoes {get; set;} = new();
    public List<Inscricao>? Inscricoes {get; set;}
}
