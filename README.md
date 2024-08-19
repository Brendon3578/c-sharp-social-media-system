# Social Media System

Este projeto em C# .NET foi desenvolvido para explorar a composição de objetos, focando na relação entre postagens e comentários, e na implementação do método `ToString` para exibição personalizada dos dados.

## Descrição

O sistema simula uma rede social básica onde é possível criar postagens e adicionar comentários a essas postagens. A relação entre as classes `Post` e `Comment` exemplifica a composição de objetos, onde um `Post` pode conter múltiplos `Comment`. Além disso, o método `ToString` é implementado para exibir os detalhes da postagem de forma estruturada.

## Funcionalidades

- **Criação de Postagens**: Cada postagem contém um título, descrição, data, número de likes e uma lista de comentários.
- **Gerenciamento de Comentários**: Permite adicionar, remover e listar comentários associados a uma postagem. Também é possível buscar comentários por autor.
- **Exibição Personalizada**: O método `ToString` foi sobrescrito tanto na classe `Post` quanto na classe `Comment` para fornecer uma exibição detalhada e formatada das informações.

## Estrutura do Código

- **Classe `Post`**: Representa uma postagem na rede social, com propriedades para título, descrição, data, autor e likes. Inclui métodos para adicionar, remover e buscar comentários, além de uma implementação do método `ToString` que exibe a postagem e seus comentários.
- **Classe `Comment`**: Representa um comentário em uma postagem, com propriedades para ID, texto e autor. Inclui uma implementação do método `ToString` que exibe os detalhes do comentário.

## Exemplo de Uso

Ao executar a aplicação, o usuário pode criar uma postagem, adicionar comentários a ela, remover comentários, listar todos os comentários, buscar comentários por autor e visualizar os detalhes formatados da postagem e dos comentários usando o método `ToString`.

## Tecnologias

- **C#**
- **.NET 8.0**

---

<h3 align="center">
    Feito com ☕ por <a href="https://github.com/Brendon3578"> Brendon Gomes</a>
</h3>
