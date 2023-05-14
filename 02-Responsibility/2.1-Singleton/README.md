# Singleton

## Aplicabilidade do Singleton:

- O padrão Singleton é recomendado quando é necessário ter apenas uma instância de uma classe em todo o sistema.
- É aplicado em situações em que há a necessidade de compartilhar um único estado ou recurso entre vários objetos ou componentes.

## Exemplos de uso do Singleton:

- Gerenciadores de log: um único objeto de log é compartilhado entre várias partes do sistema para registrar informações de log de forma centralizada.
- Pools de conexão: um único pool de conexões é criado e compartilhado por várias partes do sistema para minimizar o impacto na performance de abrir e fechar conexões com recursos externos.
- Caches: um único cache é mantido para armazenar dados frequentemente acessados e compartilhá-los entre diferentes partes do sistema.

## Considerações e desafios:

- Concorrência: é preciso considerar a concorrência ao lidar com o acesso e modificação da instância única do Singleton.
- Inicialização tardia versus inicialização precoce: decidir se a instância do Singleton será criada apenas quando necessário (inicialização tardia) ou durante a inicialização do sistema (inicialização precoce).
- Serialização e deserialização: lidar com a serialização e deserialização da instância do Singleton para preservar seu estado durante o processo.

## Exemplos de código:

<div align="center">
    <img src="https://github.com/romulodeoliveira/Design-Patterns/blob/main/02-Responsibility/2.1-Singleton/img/img1.png">
    <img src="https://github.com/romulodeoliveira/Design-Patterns/blob/main/02-Responsibility/2.1-Singleton/img/img2.png">
</div>

## Benefícios e importância do Singleton:

Mais controle sobre o acesso às propriedades e métodos de uma classe e reduzir o consumo de memória desnecessário por utilizar várias instâncias desnecessárias de uma classe são algumas das vantagens de se usar Singleton.

## Limitações e considerações:

A qualidade da implementação depende da linguagem, difícil de testar, viola o Princípio da Responsabilidade Única são algumas das desvantagens em usar este design pattern.

## Conclusão:

O padrão Singleton deve ser utilizado com muito cuidado e nas situações em que realmente fizer sentido ter apenas uma instância de uma classe. Seu uso se dá principalmente em Log e arquivos de Config.

> ## Referências:
>
> Refactoring, Singleton in C#. Disponível em: https://refactoring.guru/design-patterns/singleton/csharp/example. Acesso em: 6 de maio de 2023.
>
> Dofactory, Singleton C#. Disponível em: https://www.dofactory.com/net/singleton-design-pattern. Acesso em: 6 de maio de 2023.
>
> Macoratti, C# - O Padrão Singleton. Disponível em: https://www.macoratti.net/19/07/c_singl1.htm. Acesso em: 6 de maio de 2023.
