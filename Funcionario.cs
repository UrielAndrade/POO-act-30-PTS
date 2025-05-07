namespace AtividadePOOAvaliativa;

public class Funcionario: People
{
    private decimal salario;

    public Funcionario()
    {
        this.salario = 0;
    }
    public Funcionario(decimal salario)
    {
        this.salario = salario;
    }
    public decimal getSalario()
    {
        return this.salario;
    }   
    public void setSalario(decimal salario)
    {
        this.salario = salario;
    }
}
