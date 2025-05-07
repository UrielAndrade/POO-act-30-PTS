using System.Reflection.Metadata;

namespace AtividadePOOAvaliativa;

public class Empresa
{
private string nomeCompleto;
 private string nomeEmpresa;
 private string dataFundacao;
 private string emailCorporativo;
 private Endereco endereco;  
 public Empresa()
 {
     this.nomeCompleto = "";
     this.nomeEmpresa = "";
     this.dataFundacao = "";
     this.emailCorporativo = "";
     this.endereco = new Endereco();
 }
    public Empresa(string nomeCompleto, string nomeEmpresa, string dataFundacao, string emailCorporativo, Endereco endereco)
    {
        this.nomeCompleto = nomeCompleto;
        this.nomeEmpresa = nomeEmpresa;
        this.dataFundacao = dataFundacao;
        this.emailCorporativo = emailCorporativo;
        this.endereco = endereco;
    }
    public void setNomeCompleto(string nomeCompleto)
    {
        this.nomeCompleto = nomeCompleto;
    }
    public string getsetNomeCompleto()
    {
        return this.nomeCompleto;
    }
    public void setNomeEmpresa(string nomeEmpresa)
    {
        this.nomeEmpresa = nomeEmpresa;
    }
    public string getNomeEmpresa()
    {
        return this.nomeEmpresa;
    }
    public void setDataFundacao(string dataFundacao)
    {
        this.dataFundacao = dataFundacao;
    }
    public string getDataFundacao()
    {
        return this.dataFundacao;
    }
    public void setEmailCorporativo(string emailCorporativo)
    {
        this.emailCorporativo = emailCorporativo;
    }
    public string getEmailCorporativo()
    {
        return this.emailCorporativo;
    }
    public void setEndereco(Endereco endereco)
    {
        this.endereco = endereco;
    }
    public Endereco getEndereco()
    {
        return this.endereco;
    }
    public void setEndereco(string rua, int numero, string bairro, string cidade, string estado, string cep)
    {
        this.endereco.setRua(rua);
        this.endereco.setNumero(numero);
        this.endereco.setBairro(bairro);
        this.endereco.setCidade(cidade);
        this.endereco.setEstado(estado);
    }
}
