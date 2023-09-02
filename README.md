## Exercício 1

Crie uma classe Empresa que possua os dados básicos de uma empresa como propriedades.
Construa um método para imprimir as informações da empresa.
Construa um método abstrato void RealizarVenda()

Crie uma classe Varejo que implemente o método abstrato para imprimir que vende produtos.
Crie uma classe Empreiteira que implemente o método abstrato para imprimir que vende serviços.

Na main, crie um objeto de cada classe, preenchendo as propriedades e invocando os métodos.

## Exercício 2
Faça o mesmo exercício aplicando Interfaces.
Crie a classe base para herdar as propriedades porém façam os métodos através de implementação de Interface.

Na main, crie uma lista de interface.
Adicione um objeto de cada classe do tipo da interface, preenchendo as propriedades
Invoque os métodos da lista.

## Exercício 3

Vamos pegar o projeto de vcs da Empresa com interfaces!
Crie uma interface EnviarNotificacao com um método void EnviarMensagemCliente.
Crie uma classe EnviarNotificacaoWhatsApp, que implementa EnviarNotificacao e nela teremos o método EnviarMensagemCliente que printa a notificação: "Estou enviando uma mensagem no WhatsApp do Cliente!";

Dentro da classe Varejo, vamos incluir um private readonly EnviarNotificacaoWhatsApp que é recebido no construtor da classe.
Após Realizar a venda, utilizaremos o método de EnviarNotificacao.
