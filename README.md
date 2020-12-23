# dotnet-todoitem

[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

 <p align="center">
 <strong>API Web que pode gerenciar itens de "tarefas pendentes" armazenados em um banco de dados.</strong>
    <br />
    <a href="https://github.com/renan2911?tab=repositories"><strong>Veja outros programas »</strong></a>
    <br />
    <br />
    <a href="https://github.com/renan2911/NOME_DESSE_REPOSITORIO/issues">Reporte um Bug</a>
  </p>
</p>


##Visão Geral
API	                       | Descrição                                               |	Corpo da solicitação      |	Corpo da resposta                   |
:-------:                  |:-------:                                                |:-------:                  | :-------:                           |
GET /api/TodoItems         |	Obter todos os itens de tarefas pendentes               | Nenhum                    | Matriz de itens de tarefas pendentes|
GET /api/TodoItems/{id}	   | Obter um item por ID                                    | Nenhum	                   | Item de tarefas pendentes           |
POST /api/TodoItems        |	Adicionar um novo item	                                 | Item de tarefas pendentes | Item de tarefas pendentes           |
PUT /api/TodoItems/{id}    |	Atualizar um item   existente	Item de tarefas pendentes |	Nenhum                    | Nenhum                              |
DELETE /api/TodoItems/{id} | Excluir um item                                         | Nenhum                    | Nenhum                              |


## Foi desenvolvido:
* Criação de um projeto API Web
* Criação de uma classe de modelo e um contexto de banco de dados.
* Scaffold de um controlador com métodos CRUD.
* Configuração do roteamento, os caminhos de URL e os valores retornados.


## Pré-requisitos
* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019) - <strong>com a ASP.net e a carga de trabalho de desenvolvimento Web</strong>
* [SDK do .NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)<strong></strong>
* [Entity Framework](https://docs.microsoft.com/pt-br/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-5.0)<strong></strong>

[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=flat-square
[issues-url]: https://github.com/renan2911/usuario.api/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=flat-square
[license-url]: https://github.com/NICKNAME_DO_SEU_GITHUB/NOME_DESSE_REPOSITORIO/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/renan-alysson-f/
