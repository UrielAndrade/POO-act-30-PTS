using System;
using static System.Console;

namespace AtividadePOOAvaliativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("logradouro: ");
            string logradouro = ReadLine();
            Write("NomeRua: ");
            string nomeRua = ReadLine();
            Write("Numero: ");
            int numero = Convert.ToInt32(ReadLine());
            Write("Bairro: ");
            string bairro = ReadLine();
            Write("Cidade: ");
            string cidade = ReadLine();
            Write("Estado: ");
            string estado = ReadLine();
            Write("Cep: ");
            string cep = ReadLine();
            Endereco enderecoHotel = new Endereco($"{logradouro}", $"{nomeRua}", numero, $"{bairro}", $"{cidade}", $"{estado}", $"{cep}");

            Hotel hotel = new Hotel();
            hotel.setNomeCompleto("Hotel Luxo");
            hotel.setNomeEmpresa("Luxo Ltda");
            hotel.setDataFundacao("01/01/2000");
            hotel.setEmailCorporativo("contato@luxo.com");
            hotel.setEndereco(enderecoHotel);

            Console.WriteLine("-----------------------------------");
            WriteLine("Hotel:");
            WriteLine($"Nome Completo: {hotel.getsetNomeCompleto()}");
            WriteLine($"Nome Empresa: {hotel.getNomeEmpresa()}");
            WriteLine($"Data Fundacao: {hotel.getDataFundacao()}");
            WriteLine($"Email Corporativo: {hotel.getEmailCorporativo()}");
            WriteLine($"Endereço: Rua {hotel.getEndereco().getRua()}, Nº {hotel.getEndereco().getNumero()}, Bairro {hotel.getEndereco().getBairro()}, {hotel.getEndereco().getCidade()} - {hotel.getEndereco().getEstado()}");
            Console.WriteLine("-----------------------------------");

            Cliente cliente = new Cliente();
            endereco endCliente = new Endereco($"rua", "Jaogonsalves", 123, "Centro", "São Paulo", "SP", "12345678");
            cliente.setName("João Silva");
            cliente.setCodigo("CLI001");
            cliente.setRg("12345678");
            cliente.setCpf("111.222.333-44");
            cliente.setEndereco(endCliente);
            cliente.setProfisao("Engenheiro");

            WriteLine("-----------------------------------");
            WriteLine("Cliente:");
            WriteLine($"Nome: {cliente.getName()}");
            WriteLine($"Código: {cliente.getCodigo()}");
            WriteLine($"RG: {cliente.getRg()}");
            WriteLine($"CPF: {cliente.getCpf()}");
            WriteLine($"Profissão: {cliente.getProfisao()}");
            WriteLine("-----------------------------------");

            //Cadastro de funcionario
            Funcionario funcionario = new Funcionario();
            endereco endFuncionario = new Endereco($"rua", "Alameda", 456, "Jardins", "São Paulo", "SP", "87654321");
            funcionario.setEndereco(endFuncionario);
            funcionario.setName("Maria Oliveira");
            funcionario.setCodigo("FUN001");
            funcionario.setRg("87654321");
            funcionario.setCpf("444.333.222-11");;
            funcionario.setSalario(2500.50m);
            WriteLine("Funcionário:");
            WriteLine($"Nome: {funcionario.getName()}");
            WriteLine($"Código: {funcionario.getCodigo()}");
            WriteLine($"RG: {funcionario.getRg()}");
            WriteLine($"CPF: {funcionario.getCpf()}");
            WriteLine($"Salário: {funcionario.getSalario()}");
            WriteLine("-----------------------------------");

            //Cadastro de quarto
            Quarto quarto = new Quarto("Quarto Executivo", 101, "Executiva", 2);

            // Cadastro do Serviço
            Servico servico = new Servico("Servico de quarto", 50.00m, "Alimentacao", true);

            // Cadastro da Reserva
            Reserva reserva = new Reserva("Reserva para fim de semana", quarto, DateTime.Now, DateTime.Now.AddDays(2), 200.00m, 400.00m, servico);

            WriteLine("Reserva:");
            WriteLine($"Descrição: {reserva.getDescricao()}");
            WriteLine($"Data Início: {reserva.getDataInicio()}");
            WriteLine($"Data Fim: {reserva.getDataFim()}");
            WriteLine($"Valor Diária: {reserva.getValorDiaria()}");
            WriteLine($"Valor Total: {reserva.getValorTotal()}");
            WriteLine($"Quarto: {reserva.getQuarto().getDescricao()} - Nº {reserva.getQuarto().getNumQuarto()}");
            WriteLine($"Serviço: {reserva.getServico().getDescricao()} - Valor: {reserva.getServico().getValor()}");
            WriteLine("Cadastro finalizado. Pressione qualquer tecla para sair...");
            ReadKey();
        }

    }
}
