using cursoCSharp_Empresa;

internal class Program
{
    public static void Main(string[] args)
    {
        Varejo loja = new Varejo("Loja A", "Rua Cosmorama, 123", "12.345.678/0001-90", "(11) 1234-5678");
        Empreiteira empreiteira = new Empreiteira("Empreiteira A", "Avenida Solar, 456", "98.765.432/0001-21", "(11) 9876-5432");

        loja.ImprimirInformacoes();
        loja.RealizarVenda();

        Console.WriteLine();

        empreiteira.ImprimirInformacoes();
        empreiteira.RealizarVenda();
    }
}