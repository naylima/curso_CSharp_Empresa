using System;
namespace cursoCSharp_Empresa_Interface
{
	public class Varejo : Empresa, IEmpresaAcoes
	{
        public Varejo(string nome, string endereco, string cnpj, string telefone)
            : base(nome, endereco, cnpj, telefone) { }

        public void RealizarVenda()
        {
            Console.WriteLine("Vendendo produtos.");
        }
    }
}

