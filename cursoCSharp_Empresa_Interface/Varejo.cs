using System;
namespace cursoCSharp_Empresa_Interface
{
	public class Varejo : Empresa, IVenda, IInformacoes
	{
        public Varejo(string nome, string endereco, string cnpj, string telefone)
            : base(nome, endereco, cnpj, telefone) { }

        public void RealizarVenda()
        {
            Console.WriteLine("Vendendo produtos.");
        }
    }
}

