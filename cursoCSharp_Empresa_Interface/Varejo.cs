using System;
namespace cursoCSharp_Empresa_Interface
{
	public class Varejo : Empresa, IEmpresaAcoes
	{
        private readonly IEnviarNotificacao _notificador;

        public Varejo(string nome, string endereco, string cnpj, string telefone, IEnviarNotificacao notificador)
            : base(nome, endereco, cnpj, telefone)
        {
            _notificador = notificador;
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Vendendo produtos.");
            _notificador.EnviarMensagemCliente();
        }
    }
}

