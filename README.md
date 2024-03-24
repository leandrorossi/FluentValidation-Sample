# FluentValidation Sample
Aplicativo feito em ASP.NET CORE MVC para realizar validações com FluentValidation.

## Sobre o Projeto
Este projeto é um aplicativo ASP NET CORE MVC que realiza validações de um formulário utilizando a biblioteca FluetValidation.

## Layout
Exemplo 1:

<p align="left">
  <img alt="Exemplo 1" title="#Exemplo 1" src="./wwwroot/img/screen1.webp" width="600px">
</p>

Exemplo 2: 

<p align="left">
  <img alt="Exemplo 2" title="#Exemplo 2" src="./wwwroot/img/screen2.webp" width="600px">
</p>

Exemplo 3:

<p align="left">
  <img alt="Exemplo 3" title="#Exemplo 3" src="./wwwroot/img/screen3.webp" width="600px">
</p>

## Como rodar o projeto 
### Clone este repositório
```
git clone https://github.com/leandrorossi/redis-postgres-api.git
```

### Executando via dotnet CLI
Você pode rodar o projeto via dotnet CLI com o seguinte comando:
```
dotnet run
```

### Executando via DockerFile
O projeto possui um arquivo dockerfile caso queira rodar via docker:
```
docker image build -t fluentvalidation-sample -f .\FluentValidation-Sample\Dockerfile .

docker container run --name FluentValidantion-Sample -d -p 8080:8080 fluentvalidation-sample
```

## Tecnologias utilizadas
As seguintes ferramentas foram usadas na construção do projeto:
- ASP.NET CORE
- FluentValidation
- Docker

## Autor
 <img style="border-radius: 50%;" src="https://avatars2.githubusercontent.com/u/65093597?s=60&v=4" width="100px;" alt=""/>
 <br />
 <span><b>Feito por Leandro Rossi</b></span>
 <br />
 <br />

 [![Linkedin Badge](https://img.shields.io/badge/-Leandro-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/leandro-rossi-4769ab1a6/)](https://www.linkedin.com/in/leandro-rossi-4769ab1a6/)
 [![Outloook](https://img.shields.io/badge/le_andro18@hotmail.com-0078D4?style=flat-square&logo=microsoft-outlook&logoColor=white&link=mailto:le_andro18@hotmail.com)](mailto:le_andro18@hotmail.com)
