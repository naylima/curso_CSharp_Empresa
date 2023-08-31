using System;
namespace cursoCSharp_Empresa
{
	public abstract class Empresa
	{
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }

        public Empresa(string nome, string endereco, string cnpj, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            CNPJ = cnpj;
            Telefone = telefone;
        }

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine($"Telefone: {Telefone}");
        }

        public abstract void RealizarVenda();
    }
}

