# Projeto Estacionamento

Este projeto é um sistema simples de gerenciamento de estacionamento desenvolvido em C# utilizando .NET 6.0. O objetivo é controlar a entrada, saída e cobrança de veículos estacionados.

## Estrutura do Projeto

O projeto está dividido principalmente em dois arquivos:

- `Estacionamento.cs` (Classe)
- `Program.cs` (Programa Principal)

---

## 1. Estacionamento.cs (Classe)

Neste arquivo, foi implementada a classe `Estacionamento`, responsável por:

- **Definir propriedades** para armazenar a lista de veículos, preço inicial e preço por hora.
- **Métodos para adicionar veículos** ao estacionamento.
- **Métodos para remover veículos**, calculando o valor a ser pago com base no tempo de permanência.
- **Método para listar veículos** atualmente estacionados.
- **Validação de entrada** para evitar duplicidade de placas.

---

## 2. Program.cs (Programa Principal)

Neste arquivo, foi implementada a lógica principal do sistema:

- **Exibição do menu** para o usuário escolher entre adicionar, remover ou listar veículos.
- **Leitura das opções do usuário** e chamada dos métodos correspondentes da classe `Estacionamento`.
- **Tratamento de entradas** para garantir que o usuário insira dados válidos.
- **Loop principal** que mantém o programa em execução até o usuário optar por sair.

---

## Como Executar

1. Certifique-se de ter o .NET 6.0 instalado.
2. Compile o projeto com `dotnet build`.
3. Execute o projeto com `dotnet run`.
4. Siga as instruções exibidas no console para utilizar o sistema.

---

## Observações

- O projeto é didático e pode ser expandido para incluir persistência de dados ou interface gráfica.
- Para dúvidas ou sugestões, contribua via GitHub.
