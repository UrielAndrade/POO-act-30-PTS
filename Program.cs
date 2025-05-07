using System;
using static System.Console;

namespace AtividadePOOAvaliativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("logradouro: ");
            string logradouro= ReadLine();
            Write("NomeRua: ");
            string nomeRua= ReadLine();
            Write("Numero: ");
            int numero = Convert.ToInt32(ReadLine());
            Write("Bairro: ");
            string bairro= ReadLine();
            Write("Cidade: ");
            string cidade = ReadLine();
            Write("Estado: ");
            string estado = ReadLine();
            Write("Cep: ");
            string cep = ReadLine();
            Endereco endereco = new Endereco($"{logradouro}", $"{nomeRua}", numero, $"{bairro}", $"{cidade}", $"{estado}", $"{cep}");

            Hotel hotel = new Hotel();
            hotel.setNomeCompleto("Hotel Luxo");
            hotel.setNomeEmpresa("Luxo Ltda");
            hotel.setDataFundacao("01/01/2000");
            hotel.setEmailCorporativo("contato@luxo.com");
            hotel.setEndereco(endereco);

            Console.WriteLine("-----------------------------------");
            WriteLine("Hotel:");
            WriteLine($"Nome Completo: {hotel.getsetNomeCompleto()}");
            WriteLine($"Nome Empresa: {hotel.getNomeEmpresa()}");
            WriteLine($"Data Fundacao: {hotel.getDataFundacao()}");
            WriteLine($"Email Corporativo: {hotel.getEmailCorporativo()}");
            WriteLine($"Endereço: Rua {hotel.getEndereco().getRua()}, Nº {hotel.getEndereco().getNumero()}, Bairro {hotel.getEndereco().getBairro()}, {hotel.getEndereco().getCidade()} - {hotel.getEndereco().getEstado()}");
            Console.WriteLine("-----------------------------------");
           
            Cliente cliente = new Cliente();
            cliente.setName("João Silva");
            cliente.setCodigo("CLI001");
            cliente.setRg("12345678");
            cliente.setCpf("111.222.333-44");
            cliente.setEndereco(endereco);
            cliente.setProfisao("Engenheiro");
           
            WriteLine("-----------------------------------");
            WriteLine("Cliente:");
            WriteLine($"Nome: {cliente.getName()}");
            WriteLine($"Código: {cliente.getCodigo()}");
            WriteLine($"RG: {cliente.getRg()}");
            WriteLine($"CPF: {cliente.getCpf()}");
            WriteLine($"Profissão: {cliente.getProfisao()}");
            WriteLine("-----------------------------------");


        }
    }
}