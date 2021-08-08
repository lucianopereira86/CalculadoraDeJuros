# CalculadoraDeJuros

## Tech Stack:
- .NET 5.0
- Swashbuckle.AspNetCore
- AutoMapper
- FluentValidator
- XUnit

## Projetos presentes
### RetornaTaxaDeJuros
- Possui um endpoint: 
    - /taxaJuros: retorna a taxa de juros.
### CalculadoraDeJuros
- Possui dois endpoints:
    - /calculajuros: realiza o cálculo de juros compostos mediante valor inicial e quantidade de meses.
    - /showmethecode: retorna a URL do repositório deste projeto no GitHub.

## Antes de executar os projetos
- Detectar o IP localhost do Docker da sua máquina. Caso esteja utilizando o Docker Desktop for Windows, o arquivo de hosts (C:\Windows\System32\drivers\etc\hosts) deve conter o IP.
![host.json](/docs/hosts.JPG)

- Abrir arquivo "/src/CalculadoraDeJuros/CalculadoraDeJuros.Presentation.API/appsettings.json". Na linha 11, substituir o IP presente na URL do campo "ApiTaxaJuros" pelo obtido anteriormente. No exemplo, o valor é 192.168.100.4.
![appsettings.json](/docs/appsettings.JPG)


## Executar os projetos
- Em "/src", executar o comando:
`docker-compose up --build`  

- Após o build ser finalizado, as APIs estarão acessíveis nos seguintes endereços:  
    RetornaTaxaDeJuros: http://localhost:5001/swagger/index.html  

    ![swagger2](/docs/swagger2.JPG)  
    
    CalculadoraDeJuros: http://localhost:5002/swagger/index.html  
    
    ![swagger1](/docs/swagger1.JPG)  

## Executar os testes
- Os testes são divididos por camadas: BO (BusinessOperations), Domain e Integration.

- Em "/src/CalculadoraDeJuros/CalculadoraDeJuros.Tests", executar o comando:
`dotnet test`  

![test1](/docs/test1.JPG)  
_Resultado visível pelo Visual Studio 2019_

- Em "/src/RetornaTaxaDeJuros/RetornaTaxaDeJuros.Tests", executar o comando
`dotnet test`  

![test2](/docs/test2.JPG)  
_Resultado visível pelo Visual Studio 2019_