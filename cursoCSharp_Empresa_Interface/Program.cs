using cursoCSharp_Empresa_Interface;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Empresa> empresas = new List<Empresa>
        {
            new Varejo("Loja A", "Rua Cosmorama, 123", "12.345.678/0001-90", "(11) 1234-5678"),
            new Empreiteira("Empreiteira A", "Avenida Solar, 456", "98.765.432/0001-21", "(11) 9876-5432")
        };

        foreach (var empresa in empresas)
        {
            if (empresa is IInformacoes info)
            {
                info.ImprimirInformacoes(empresa);
            }

            if (empresa is IVenda vendedor)
            {
                vendedor.RealizarVenda();
            }
            Console.WriteLine();
        }
    }
}