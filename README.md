# 🗺️ plann.er

Este projeto é uma API back-end em C#, desenvolvida durante o **NLW Journey** da [Rocketseat][rocketseat-linkedin-url]. A API, chamada **plann.er**, permite que o usuários cadastrem viagens, atividades e completem as suas atividades conforme a demanda.

<!-- Confira o deploy da API 🗺️ [plann.er &#8226; API][deploy]. -->

## 🚀 Começando

- **[Especificações da API](#especificações-da-api)**
- **[Tecnologias Utilizadas](#%EF%B8%8F-tecnologias-utilizadas)**
- **[Instalação de Pacotes](#-instalação-de-pacotes)**
- **[Templates](templates)**

## 🌟 Especificações da API

Veja a [Documentação Swagger da API ][documentation-url].

### Regras de negócio

---

- ✅ O usuário pode cadastrar viagens;
- ✅ O usuário pode consultar viagens;
- ✅ O usuário pode buscar uma viagem com suas atividades;
- ✅ O usuário pode deletar uma viagem;
- ✅ O usuário pode criar atividades para uma viagem;
- ✅ O usuário pode concluir uma atividades de uma viagem;
- ✅ O usuário pode deletar uma atividade.

## 🛠️ Tecnologias Utilizadas

- 🖥️ [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/): Linguagem de programação versátil e poderosa, amplamente utilizada para desenvolvimento de software;
- 🌐 [ASP.Net Core](https://learn.microsoft.com/pt-br/dotnet/api/?view=aspnetcore-8.0): Framework de desenvolvimento web open-source da Microsoft, multiplataforma e de alto desempenho, utilizado para criar aplicativos web modernos e escaláveis;
- 🔄 [Entity Framework](https://learn.microsoft.com/en-us/ef/): Framework de mapeamento objeto-relacional para .NET que simplifica o acesso e manipulação de dados em bancos de dados relacionais;
- 🛢️ [SQLite](https://www.sqlite.org/): Banco de dados relacional leve, ideal para aplicativos móveis e sistemas embarcados. Não requer um servidor separado e suporta SQL padrão;
- 👍 [FluentValidation](https://docs.fluentvalidation.net/en/latest/): Biblioteca popular no ecossistema .NET que facilita a validação de objetos, ela permite definir regras de validação para as propriedades de um objeto, melhorando a clareza e a mantenibilidade do código de validação.

## 📋 Pré-requisitos

Necessita de .Net 8 para rodar. Verifique a versão do .Net instalada na sua máquina com o seguinte comando:

```bash
dotnet --version
```

Caso encontre dificuldades, experimente atualizar o Visual Studio para a versão mais recente.

### 📦 Instalação de Pacotes

---

#### Journey.API

- Swashbuckle.AspNetCore.

#### Journey.Infrastructure

- FluentValidation;
- Microsoft.EntityFrameworkCore.Sqlite;
- Microsoft.EntityFrameworkCore.

## ✨ Templates

- [Template do projeto][template-projeto-url]
- [Template de banco de dados][template-banco-url]

## ✒️ Autores

- **Rocketseat** - _NLW Journey C#_ - [Rocketseat Education][rocketseat-git-url]

## 🖇️ Contribuição

- **Wellington Henrique** - _Implementação em aula_ - [LinkedIn][linkedin-url]

## Banner do Projeto

![Banner](./banner-figma.png)

Se você encontrar problemas, bugs ou tiver sugestões para melhorar este projeto, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## 📜 Licença

MIT

## 🙏 Expressões de gratidão

- Agradeço a [Rocketseat][rocketseat-linkedin-url] por compartilhar este conhecimento!🫂.

---

<!-- 🎟️ [pass.in &#8226; API][deploy] com ❤️ por [Wellington Henrique][linkedin-url] 😊 -->

[linkedin-url]: https://www.linkedin.com/in/wellingtonhlc/
[documentation-url]: https://wellington-henrique.github.io/nlw-journey-csharp-api/
[rocketseat-linkedin-url]: https://www.linkedin.com/school/rocketseat/
[rocketseat-git-url]: https://github.com/rocketseat-education/nlw-journey-c-sharp
[template-projeto-url]: https://github.com/Wellington-Henrique/nlw-journey-csharp-api/blob/master/templates/Journey.zip
[template-banco-url]: https://github.com/Wellington-Henrique/nlw-journey-csharp-api/blob/master/templates/JourneyDatabase.db
