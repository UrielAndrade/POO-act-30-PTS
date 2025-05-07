namespace AtividadePOOAvaliativa;

public class Quarto
{
    private string descricao;
    private int numQuarto;
    private string categoria;
    private int qntcamas;

    public Quarto(string descricao, int numQuarto, string categoria, int qntcamas)
    {
        this.descricao = descricao;
        this.numQuarto = numQuarto;
        this.categoria = categoria;
        this.qntcamas = qntcamas;
    }
    public Quarto()
    {
        this.descricao = "";
        this.numQuarto = 0;
        this.categoria = "";
        this.qntcamas = 0;
    }
    public void setDescricao(string descricao)
    {
        this.descricao = descricao;
    }
    public string getDescricao()
    {
        return descricao;
    }
    public void setNumQuarto(int numQuarto)
    {
        this.numQuarto = numQuarto;
    }
    public int getNumQuarto()
    {
        return numQuarto;
    }
    public void setCategoria(string categoria)
    {
        this.categoria = categoria;
    }
    public string getCategoria()
    {
        return categoria;
    }
    public void setQntCamas(int qntcamas)
    {
        this.qntcamas = qntcamas;
    }
    public int getQntCamas()
    {
        return qntcamas;
    }
}
