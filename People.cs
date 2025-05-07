namespace AtividadePOOAvaliativa;

public class People
{
    private string  name;
    private string  codigo;
    private string  rg;
    private string  cpf;
    private Endereco endereco;
    
    public People()
    {
        this.name = "";
        this.codigo = "";
        this.rg = "";
        this.cpf = "";
        this.endereco = new Endereco();
    }
    public People(string name, string codigo, string rg, string cpf, Endereco endereco)
    {
        this.name = name;;
        this.codigo = codigo;
        this.rg = rg;
        this.cpf = cpf;
        this.endereco = endereco;
    }
    // Setters and Getters for name
    public void setName(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return this.name;
    }
    // Setters and Getters for codigo
    public void setCodigo(string codigo)
    {
        this.codigo = codigo;
    }
    public string getCodigo()
    {
        return this.codigo;
    }
    // Setters and Getters for cpf
    public void setCpf(string cpf)
    {
        this.cpf = cpf;
    }
    public string getCpf()
    {
        return this.cpf;
    }
    // Setters and Getters for rg
    public void setRg(string rg)
    {
        this.rg = rg;
    }
    public string getRg()
    {
        return this.rg;
    }
    public Endereco getEndereco()
    {
        return this.endereco;
    }
    public void setEndereco(Endereco endereco)
    {
        this.endereco = endereco;
    }
}
