using System;
namespace cursoCSharp_Empresa_Interface
{
	public interface IEmpresaAcoes
    {
        void RealizarVenda();

        void ImprimirInformacoes(Empresa empresa)
        {
            Console.WriteLine($"Nome: {empresa.Nome}");
            Console.WriteLine($"Endereço: {empresa.Endereco}");
            Console.WriteLine($"CNPJ: {empresa.CNPJ}");
            Console.WriteLine($"Telefone: {empresa.Telefone}");
        }
    }
}

