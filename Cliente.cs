namespace AtividadePOOAvaliativa;

public class Cliente: People
{
    private string profisao;
    
    public Cliente()
    {
        this.profisao = "";
    }
    public Cliente(string profisao)
    {
        this.profisao = profisao;
    }

    public string getProfisao()
    {
        return this.profisao;
    }
    public void setProfisao(string profisao)
    {
        this.profisao = profisao;
    }
}
