using System;
namespace cursoCSharp_Empresa_Interface
{
	public class Empreiteira : Empresa, IEmpresaAcoes
	{
        public Empreiteira(string nome, string endereco, string cnpj, string telefone)
            : base(nome, endereco, cnpj, telefone) { }

        public void RealizarVenda()
        {
            Console.WriteLine("Vendendo serviços.");
        }
    }
}

