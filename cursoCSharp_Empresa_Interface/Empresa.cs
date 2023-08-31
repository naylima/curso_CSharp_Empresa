using System;
namespace cursoCSharp_Empresa_Interface
{
	public class Empresa
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
    }
}

