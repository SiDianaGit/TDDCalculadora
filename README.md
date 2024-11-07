# TDDCalculadora
 Criação de projeto para implementação de uma calculadora utilizando metodologia  TDD

## Visão Geral
Este projeto implementa uma calculadora simples de linha de comando em C# chamada AppCalculadora. Ela permite aos usuários realizar operações matemáticas básicas e visualizar um histórico dos últimos 3 cálculos.

## Funcionalidades
Realizar adição, subtração, multiplicação e divisão.
Manter um histórico dos últimos 3 cálculos.
Exibir o histórico de cálculos.
## Uso
Compile o projeto usando sua ferramenta de compilação .NET favorita.
Execute o programa compilado.
Digite dois números seguidos do símbolo da operação desejada (+, -, *, /).
O programa exibirá o resultado e atualizará o histórico.
Use o método Listar() (chamado internamente) para visualizar as 3 últimas operações.
Observação: Este é um exemplo simples e não lida com entradas inválidas (por exemplo, divisão por zero).

## Estrutura do Código
Calcular.cs: Esta classe define a funcionalidade da calculadora.
Contém métodos para cada operação (Somar, Subtrair, Multiplicar, Dividir).
Cada método executa o cálculo, armazena a operação em uma lista de histórico (historico) e retorna o resultado.
O método Listar() recupera as últimas 3 operações da lista de histórico e as retorna.
Program.cs (não incluso no código fornecido): Este arquivo (provavelmente chamado Program.cs) seria normalmente o ponto de entrada da aplicação. Ele criaria uma instância da classe Calcular e chamaria os métodos desejados.
## Dependências
Este projeto usa os seguintes namespaces do .NET:

System
System.Collections.Generic
System.Linq
Esses namespaces fornecem funcionalidades para operações básicas, estruturas de dados e consultas LINQ, respectivamente.

## Melhorias Futuras
Implementar tratamento de erros para entrada inválida do usuário.
Aprimorar a interface do usuário com menus e prompts.
Permitir que os usuários visualizem todo o histórico em vez de apenas as últimas 3 operações.
