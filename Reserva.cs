namespace AtividadePOOAvaliativa;

public class Reserva
{
    private string descricao;
    private Quarto quarto;
    private DateTime dataInicio;
    private DateTime dataFim;
    private decimal valorDiaria;
    private decimal valorTotal;
    private Servico servico;


    public Reserva()
    {
        this.descricao = "";
        this.quarto = new Quarto();
        this.dataInicio = DateTime.Now;
        this.dataFim = DateTime.Now;
        this.valorDiaria = 0;
        this.valorTotal = 0;
        this.servico = new Servico();
    }  
    public Reserva(string descricao, Quarto quarto, DateTime dataInicio, DateTime dataFim, decimal valorDiaria, decimal valorTotal, Servico servico)
    {
        this.descricao = descricao;
        this.quarto = quarto;
        this.dataInicio = dataInicio;
        this.dataFim = dataFim;
        this.valorDiaria = valorDiaria;
        this.valorTotal = valorTotal;
        this.servico = servico;
    }
    public void setDescricao(string descricao)
    {
        this.descricao = descricao;
    }
    public string getDescricao()
    {
        return this.descricao;
    }
    public void setQuarto(Quarto quarto)
    {
        this.quarto = quarto;
    }
    public Quarto getQuarto()
    {
        return this.quarto;
    }
    public void setDataInicio(DateTime dataInicio)
    {
        this.dataInicio = dataInicio;
    }
    public DateTime getDataInicio()
    {
        return this.dataInicio;
    }
    public void setDataFim(DateTime dataFim)
    {
        this.dataFim = dataFim;
    }
    public DateTime getDataFim()
    {
        return this.dataFim;
    }
    public void setValorDiaria(decimal valorDiaria)
    {
        this.valorDiaria = valorDiaria;
    }
    public decimal getValorDiaria()
    {
        return this.valorDiaria;
    }
    public void setValorTotal(decimal valorTotal)
    {
        this.valorTotal = valorTotal;
    }
    public decimal getValorTotal()
    {
        return this.valorTotal;
    }
    public void setServico(Servico servico)
    {
        this.servico = servico;
    }
    public Servico getServico()
    {
        return this.servico;
    }
}
