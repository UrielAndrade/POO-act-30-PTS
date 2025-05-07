namespace AtividadePOOAvaliativa;

public class Endereco
{
    private string logradouro, bairro, cidade,rua, estado, cep;
    private int numero;
    public Endereco()
    {
        this.rua = "";
        this.logradouro = "";
        this.numero = 0;
        this.bairro = "";
        this.cidade = "";
        this.estado = "";
        this.cep = "";
    }
    public Endereco(string logradouro,string rua, int numero, string bairro, string cidade, string estado,string cep)
    {
        this.rua = rua;
        this.logradouro = logradouro;
        this.numero = numero;
        this.bairro = bairro;
        this.cidade = cidade;
        this.estado = estado;
        this.cep = cep;
    }
    public void setLogradouro(string logradouro)
    {
        this.logradouro = logradouro;
    }
    public string getLogradouro()
    {
        return this.logradouro;
    }

    public void setNumero(int numero)
    {
        this.numero = numero;
    }
    public int getNumero()
    {
        return this.numero;
    }

    public void setBairro(string bairro)
    {
        this.bairro = bairro;
    }
    public string getBairro()
    {
        return this.bairro;
    }

    public void setCidade(string cidade)
    {
        this.cidade = cidade;
    }
    public string getCidade()
    {
        return this.cidade;
    }

    public void setEstado(string estado)
    {
        this.estado = estado;
    }
    public string getEstado()
    {
        return this.estado;
    }
    public void setRua(string rua)
    {
        this.rua = rua;
    }
    public string getRua()
    {
        return this.rua;
    }
    public void setCep(string cep)
    {
        this.cep = cep;
    }
    public string getCep()
    {
        return this.cep;
    }
    public string getEnderecoCompleto()
    {
        return $"{logradouro}, {rua}, {numero}, {bairro}, {cidade}, {estado}, {cep}";
    }
}
