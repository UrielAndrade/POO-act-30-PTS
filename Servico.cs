namespace AtividadePOOAvaliativa;

public class Servico
{
    private string descricao;
    private decimal valor;
    private string categoria;
    private bool ativo;

    public Servico(string descricao, decimal valor, string categoria, bool ativo)
    {
        this.descricao = descricao;
        this.valor = valor;
        this.categoria = categoria;
        this.ativo = ativo;
    }
    public Servico()
    {
        this.descricao = "";
        this.valor = 0;
        this.categoria = "";
        this.ativo = false;
    }
    public void setDescricao(string descricao)
    {
        this.descricao = descricao;
    }
    public string getDescricao()
    {
        return descricao;
    }
    public void setValor(decimal valor)
    {
        this.valor = valor;
    }
    public decimal getValor()
    {
        return valor;
    }
    public void setCategoria(string categoria)
    {
        this.categoria = categoria;
    }
    public string getCategoria()
    {
        return categoria;
    }
    public void setAtivo(bool ativo)
    {
        this.ativo = ativo;
    }
    public bool getAtivo()
    {
        return ativo;
    }
}
