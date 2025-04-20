# Repository Pattern

Consiste em elaborar uma separação lógica de acesso a dados das regras de negócios. Funciona como uma camada de abstração (interface) entre a aplicação e a fonte de dados.

## Benefícios

- Separação de responsabilidade: como foi dito, a ideia desse padrão é realizar uma separação lógica, o que evita acoplamento, facilita a compreensão e manutenção.

- Testabilidade: por não depender de implementações, cada repositório criado dentro de uma aplicação pode ser sobrescrito, por exemplo, para utilizar uma base de dados em memória, o que facilita a realização de testes.

- Flexibilidade: facilita a troca de banco de dados sem modificar as regras de negócio atuais. A implementação pode ser facilmente substituída.

# Repositórios genéricos

Classe base da qual outras derivam. Não é muito recomendado utilizá-los. Muitas queries são específicas, e o uso de algo genérico acaba sendo subutilizado. Em DDD e Clean Architecture, é bem comum termos queries específicas. Nem sempre vamos fazer um CRUD completo, então certos métodos acabam sendo subutilizados.

# Aggregate Root

"Entidades fortes". Tudo é persistido através dessa entidade. Essa interface é utilizada como base nas interfaces de repositório, garantindo que só teremos repositórios de entidades que estendam de IAggregateRoot.

A raiz de agregação é a base, e, através dela, são manipuladas as entidades filhas. Dessa forma, os repositórios só poderão receber entidades raiz.

## Exemplo

Imagine que você tenha uma entidade Computador. Essa entidade não pode viver sem o software e o hardware. Logo, software e hardware compõem a entidade Computador. Dessa forma, podemos dizer que Computador é nossa entidade raiz (entidade principal) que encapsula o conjunto de entidades derivadas e relacionadas: Software e Hardware. Qualquer modificação em Software ou Hardware deve ser feita através da entidade Computador.


# Specification Pattern

Classe onde podemos concentrar uma regra de negócio. Por exemplo: podemos ter um repositório com métodos que retornam produtos ativos, produtos com preço abaixo de um valor X, total de produtos que foram vendidos no mês passado, etc. Na abordagem comum, teríamos um método para cada uma dessas regras, e, sempre que surgisse uma nova, seria necessário criar um novo método. Essa forma de trabalhar acaba ferindo o princípio Open-Closed do SOLID, pois nos força a modificar nossa implementação toda vez que um novo requisito surge.

Como forma de tratar a situação descrita anteriormente, surge o pattern Specification. A ideia central desse padrão é encapsular cada regra de negócio em classes específicas, chamadas de especificações. Em vez de criar múltiplos métodos especializados para cada regra no repositório, esse padrão permite concentrar toda a lógica de decisão em especificações reutilizáveis. Assim, o repositório precisa apenas de um único método capaz de trabalhar com essas especificações, garantindo maior aderência ao princípio Open-Closed do SOLID, pois novas regras podem ser adicionadas sem modificar o código existente, apenas criando novas especificações. Essa abordagem promove uma estrutura mais modular e fácil de manter.

A base do texto escrito acima foi realizado com base nas referências abaixo.

# Referências

- https://www.youtube.com/watch?v=49Y2nBFbXGQ;
- https://blog.balta.io/repository-pattern-em-aplicacoes-net/ (Bernardo Meine);
- https://stackoverflow.com/questions/1958621/whats-an-aggregate-root;
- https://renatogontijo.medium.com/aggregate-root-na-modelagem-de-dom%C3%ADnios-ricos-7317238e6d97;
- https://www.martinfowler.com/bliki/DDD_Aggregate.html?source=post_page-----7317238e6d97---------------------------------------;
- https://tallesvaliatti.com/design-pattern-specification-ac43378b2d7d.



