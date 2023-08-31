using System;
namespace cursoCSharp_Empresa
{
	public class Empreiteira : Empresa
	{
        public Empreiteira(string nome, string endereco, string cnpj, string telefone)
            : base(nome, endereco, cnpj, telefone) { }

        public override void RealizarVenda()
        {
            Console.WriteLine("Vendendo serviços.");
        }
    }
}

