# Introdução aos Design Patterns

## Definição de design patterns

Design Patterns são Padrões de Projetos que foram surgindo durante as experiências de diversos projetos de softwares, principalmente depois da adoção em massa da programação orientada a objeto. Os padrões se tornaram de conhecimento público quando os engenheiros de softwares Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides decidiram estabelecer e catalogar os problemas mais comuns e as formas de resolvê-los. Foi aí que, em 1994, lançaram o livro “Design Patterns: Elements of Reusable Object – Oriented Software”, que acabou virando uma espécie de bíblia sobre o assunto. O quarteto ficou conhecido como “Gang of Four” ou simplesmente **GoF**.

Um padrão descreve um conjunto composto por um _contexto_, um _problema_ e uma _solução_. Em outras palavras, pode-se descrever um padrão como uma solução para um determinado problema em um contexto. Porém um padrão não descreve qualquer solução, mas uma solução que já tenha sido utilizada com sucesso em mais de um contexto. Exatamente por esse motivo que a descrição dos padrões normalmente sempre indica alguns de seus usos conhecidos. Um padrão não descreve soluções novas, mas soluções consolidadas.

## Benefícios e importância dos design patterns:

Conhecer diversas soluções sem precisar passar por vários anos alternando entre escolhas certas e erradas. Saber o contexto em que essas soluções são adequadas e quais são as contrapartidas dos benefícios da solução?

## Categorias principais de design patterns (criacionais, estruturais, comportamentais)

Há várias formas de classificar os padrões. _Gamma et al_ os classifica de duas formas:

- Por propósito:
  1. criação de classes e objetos,
  1. alteração da estrutura de um programa,
  1. controle do seu comportamento.
- Por escopo: _classe_ ou _objeto_.

Metsker os classifica em 5 grupos, por intenção (problema a ser solucionado):

1. oferecer uma interface,
1. atribuir uma responsabilidade,
1. realizar a construção de classes ou objetos,
1. controlar formas de operação,
1. implementar uma extensão para a aplicação.

### Classificação dos padrões GoF "clássicos" selecionados e organizados por Gamma et al:

<table>
  <tr>
    <th colspan="2"></th>
    <th colspan="3">Propósito</th>
  </tr>
  <tr>
    <th></th>
    <th></th>
    <th>01. Criação</th>
    <th>02. Estrutura</th>
    <th>03. Comportamento</th>
  </tr>
  <tr>
    <td rowspan="10">Escopo</td>
    <td>Classe</td>
    <td>Factory Method</td>
    <td>Class Adapter</td>
    <td>Interpreter Template Method</td>
  </tr>
  <tr>
    <td rowspan=9>Objeto</td>
    <td>Abstract Factory</td>
    <td>Object Adapter</td>
    <td>Chain of Responsibility</td>
  </tr>
  <tr>
    <td>Builder</td>
    <td>Bridge</td>
    <td>Command</td>
  </tr>
  <tr>
    <td>Prototype</td>
    <td>Composite</td>
    <td>Iterator</td>
  </tr>
  <tr>
    <td>Singleton</td>
    <td>Decorator</td>
    <td>Mediator</td>
  </tr>
  <tr>
    <td></td>
    <td>Facade</td>
    <td>Memento</td>
  </tr>
  <tr>
    <td></td>
    <td>Flyweight</td>
    <td>Observer</td>
  </tr>
  <tr>
    <td></td>
    <td>Proxy</td>
    <td>State</td>
  </tr>
  <tr>
    <td></td>
    <td></td>
    <td>Strategy</td>
  </tr>
  <tr>
    <td></td>
    <td></td>
    <td>Visitor</td>
  </tr>
</table>

#### Padrões de Design Criacionais

Os padrões criacionais fornecem vários mecanismos de criação de objetos, que aumentam a flexibilidade e reutilização de código já existente.

1. Factory Method, também conhecido como "Método fábrica", "Construtor virtual" é um padrão criacional de projeto que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão criados.

1. Abstract Factory permite que você produza famílias de objetos relacionados sem ter que especificar suas classes concretas.

1. Builder permite construir objetos complexos passo a passo. O padrão permite produzir diferentes tipos e representações de um objeto usando o mesmo código de construção.

1. Prototype permite que você copie objetos existentes sem fazer seu código ficar dependente de suas classes.

1. Singleton permite a você garantir que uma classe tem apenas uma instância, enquanto provê um ponto de acesso global para esta instância.

#### Padrões de Design Estruturais

Os padrões estruturais são os que tratam da relação entre os objetos e como eles interagem entre si para formarem objetos grandes e complexos.

1. Class Adapter usa herança e só pode encapsular uma classe. Ele não pode agrupar uma interface, pois, por definição, deve derivar de alguma classe base. Essa abordagem só pode ser implementada em linguagens de programação que suportam herança múltipla, tais como C++.

1. O Object Adapter usa o princípio de composição do objeto e pode agrupar classes ou interfaces, ou ambos. Ele pode fazer isso, pois contém, como um membro privado e encapsulado, a classe ou a instância do objeto de interface que envolve. Essa abordagem pode ser implementada em várias linguagens de programação, incluindo C#.

1. Bridge permite que você divida uma classe grande ou um conjunto de classes intimamente ligadas em duas hierarquias separadas — abstração e implementação — que podem ser desenvolvidas independentemente umas das outras.

1. Composite permite que você componha objetos em estruturas de árvores e então trabalhe com essas estruturas como se elas fossem objetos individuais.

1. Decorator permite que você acople novos comportamentos para objetos ao colocá-los dentro de invólucros de objetos que contém os comportamentos.

1. Facade simplifica a utilização de subsistemas complexos, fornecendo uma interface simplificada para uma biblioteca, um framework, ou qualquer conjunto complexo de classes.

1. Flyweight permite a você colocar mais objetos na quantidade de RAM disponível ao compartilhar partes comuns de estado entre os múltiplos objetos ao invés de manter todos os dados em cada objeto.

1. Proxy permite que você forneça um substituto ou um espaço reservado para outro objeto. Um proxy controla o acesso ao objeto original, permitindo que você faça algo ou antes ou depois do pedido chegar ao objeto original.

#### Padrões de Design Comportamentais

1. O Template Method é um padrão de projeto comportamental que define o esqueleto de um algoritmo na superclasse mas deixa as subclasses sobrescreverem etapas específicas do algoritmo sem modificar sua estrutura.

1. O Chain of Responsibility é um padrão de projeto comportamental que permite que você passe pedidos por uma corrente de handlers. Ao receber um pedido, cada handler decide se processa o pedido ou o passa adiante para o próximo handler na corrente.

1. O Command é um padrão de projeto comportamental que transforma um pedido em um objeto independente que contém toda a informação sobre o pedido. Essa transformação permite que você parametrize métodos com diferentes pedidos, atrase ou coloque a execução do pedido em uma fila, e suporte operações que não podem ser feitas.

1. O Iterator é um padrão de projeto comportamental que permite a você percorrer elementos de uma coleção sem expor as representações dele (lista, pilha, árvore, etc.)

1. O Mediator é um padrão de projeto comportamental que permite que você reduza as dependências caóticas entre objetos. O padrão restringe comunicações diretas entre objetos e os força a colaborar apenas através do objeto mediador.

1. O Memento é um padrão de projeto comportamental que permite que você salve e restaure o estado anterior de um objeto sem revelar os detalhes de sua implementação.

1. O Observer é um padrão de projeto comportamental que permite que você defina um mecanismo de assinatura para notificar múltiplos objetos sobre quaisquer eventos que aconteçam com o objeto que eles estão observando.

1. O State é um padrão de projeto comportamental que permite que um objeto altere seu comportamento quando seu estado interno muda. Parece como se o objeto mudasse de classe.

1. O Strategy é um padrão de projeto comportamental que permite que você defina uma família de algoritmos, coloque-os em classes separadas, e faça os objetos deles intercambiáveis.

1. O Visitor é um padrão de projeto comportamental que permite que você separe algoritmos dos objetos nos quais eles operam.

### Classificação dos padrões GoF segundo Metsker

<table>
  <tr>
    <th>Intenção</th>
    <th>Padrões</th>
  </tr>
  <tr>
    <td><b>1. Interfaces</b></td>
    <td>Adapter, Facade, Composite, Bridge</td>
  </tr>
  <tr>
    <td><b>2. Responsabilidade</b></td>
    <td>Singleton, Observer, Mediator, Proxy, Chain of Responsibility, Flyweight</td>
  </tr>
  <tr>
    <td><b>3. Construção</b></td>
    <td>Builder, Factory Method, Abstract Factory, Prototype, Memento</td>
  </tr>
  <tr>
    <td><b>4. Operações</b></td>
    <td>Template Method, State, Strategy, Command, Interpreter</td>
  </tr>
  <tr>
    <td><b>5. Extensões</b></td>
    <td>Decorator, Iterator, Visitor</td>
  </tr>
</table>

Usarei essa classificação nos meus estudos.

## Estudos de Caso e Exemplos Práticos

<table>
  <tr>
    <th><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/01-Interface">1. Interfaces</a></th>
    <th><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/02-Responsibility">2. Responsabilidades</a></th>
    <th><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/03-Construction">3. Construção</a></th>
    <th><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/04-Operation">4. Operações</a></th>
    <th><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/05-Extension">5. Extensões</a></th>
  </tr>
  <tr>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/01-Interface/1.1-Adapter">1.1 Adapter</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/02-Responsibility/2.1-Singleton">2.1 Singleton</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/03-Construction/3.1-Builder">3.1 Builder 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/04-Operation/4.1-Template-Method">4.1 Template Method 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/05-Extension/5.1-Decorator">5.1 Decorator 🔧</a></td>
  </tr>
  <tr>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/01-Interface/1.2-Facade">1.2 Facade 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/02-Responsibility/2.2-Observer">2.2 Observer 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/03-Construction/3.2-Factory-Method">3.2 Factory Method 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/04-Operation/4.2-State">4.2 State 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/05-Extension/5.2-Iterator">5.2 Iterator 🔧</a></td>
  </tr>
  <tr>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/01-Interface/1.3-Composite">1.3 Composite 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/02-Responsibility/2.3-Mediator">2.3 Mediator 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/03-Construction/3.3-Abstract-Factory">3.3 Abstract Factory 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/04-Operation/4.3-Strategy">4.3 Strategy 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/05-Extension/5.3-Visitor">5.3 Visitor 🔧</a></td>
  </tr>
  <tr>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/01-Interface/1.4-Bridge">1.4 Bridge 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/02-Responsibility/2.4-Proxy">2.4 Proxy 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/03-Construction/3.4-Prototype">3.4 Prototype 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/04-Operation/4.4-Command">4.4 Command 🔧</a></td>
    <td><a href=""></a></td>
  </tr>
  <tr>
    <td><a href=""></a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/02-Responsibility/2.5-Chain-of-Responsibility">2.5 Chain of Responsibility 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/03-Construction/3.5-Memento">3.5 Memento 🔧</a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/04-Operation/4.5-Interpreter">4.5 Interpreter 🔧</a></td>
    <td><a href=""></a></td>
  </tr>
  <tr>
    <td><a href=""></a></td>
    <td><a href="https://github.com/romulodeoliveira/Design-Patterns/tree/main/02-Responsibility/2.6-Flyweight">2.6 Flyweight 🔧</a></td>
    <td><a href=""></a></td>
    <td><a href=""></a></td>
    <td><a href=""></a></td>
  </tr>
</table>

## Considerações Finais

A utilização dos padrões de projeto representam um ganho de produtividade, pois evitam que sejam desperdiçados tempo e energia para solucionar problemas em comum. O seu uso também contribui para uma melhor organização e manutenção dos projetos. Além disso, as discussões técnicas se tornam mais sucintas, pois é mais fácil citar o nome de um Design Patterns ao invés de ter que explicar todo o seu comportamento e justificá-lo. É importante, porém, ter bom senso ao utilizá-los. Apesar do seu objetivo ser ajudar e facilitar os processos, existem casos em que não devem ser utilizados. Portanto, é ideal avaliar com cautela cada situação.

## Referências:

GUERRA, Eduardo. Design Patterns com Java: Projeto orientado a objetos guiado por padrões. Casa do Código, 2014.

SHVETS, Alexander. Mergulo nos Padrões de Projeto. Refactoring Guru, 2021.

Hostgator. Conheça os diferentes tipos de Design Patterns e seus benefícios. Disponível em: https://www.hostgator.com.br/blog/design-patterns-e-seus-beneficios/. Acesso em 14 de maio de 2023.
