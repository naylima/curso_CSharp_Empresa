# Exercícios de Programação Orientada a Objetos

## Exercício 1: Classes e Métodos Abstratos

### Descrição:
- **Classe Empresa**:
  - Propriedades básicas de uma empresa.
  - Método para imprimir informações da empresa.
  - Método abstrato `void RealizarVenda()`.

- **Classe Varejo**:
  - Implementa o método abstrato e imprime que a empresa vende produtos.

- **Classe Empreiteira**:
  - Implementa o método abstrato e imprime que a empresa vende serviços.

**Execução**:
Na função main, crie um objeto de cada classe, preencha suas propriedades e invoque os métodos pertinentes.

## Exercício 2: Aplicação de Interfaces

### Descrição:
- Implemente o exercício anterior usando interfaces.
- Crie uma classe base para herdar as propriedades.
- Implemente os métodos usando interfaces.

**Execução**:
Na função main, crie uma lista de interface. Adicione um objeto de cada classe (do tipo da interface), preencha suas propriedades e invoque os métodos da lista.

## Exercício 3: Notificações via Interface

### Descrição:
- Baseado no projeto do Exercício 2 (Empresa com interfaces):
  - **Interface EnviarNotificacao**:
    - Método: `void EnviarMensagemCliente()`.

  - **Classe EnviarNotificacaoWhatsApp**:
    - Implementa a interface `EnviarNotificacao`.
    - O método `EnviarMensagemCliente` imprime: "Estou enviando uma mensagem no WhatsApp do Cliente!".

  - **Classe Varejo** (modificação):
    - Inclui uma instância privada e somente leitura de `EnviarNotificacaoWhatsApp`, recebida no construtor da classe.
    - Após realizar a venda, utilize o método `EnviarNotificacao`.

