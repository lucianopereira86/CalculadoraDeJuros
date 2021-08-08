#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5002
EXPOSE 444

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./CalculadoraDeJuros.Presentation.API/CalculadoraDeJuros.Presentation.API.csproj", "./CalculadoraDeJuros.Presentation.API/"]
COPY ["./CalculadoraDeJuros.Application.BusinessOperations/CalculadoraDeJuros.Application.BusinessOperations.csproj", "./CalculadoraDeJuros.Application.BusinessOperations/"]
COPY ["./CalculadoraDeJuros.Domain.Domain/CalculadoraDeJuros.Domain.Domain.csproj", "./CalculadoraDeJuros.Domain.Domain/"]
COPY ["./CalculadoraDeJuros.Infra.CrossCutting/CalculadoraDeJuros.Infra.CrossCutting.csproj", "./CalculadoraDeJuros.Infra.CrossCutting/"]
COPY ["./CalculadoraDeJuros.Infra.Services/CalculadoraDeJuros.Infra.Services.csproj", "./CalculadoraDeJuros.Infra.Services/"]
RUN dotnet restore "./CalculadoraDeJuros.Presentation.API/CalculadoraDeJuros.Presentation.API.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./CalculadoraDeJuros.Presentation.API/CalculadoraDeJuros.Presentation.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./CalculadoraDeJuros.Presentation.API/CalculadoraDeJuros.Presentation.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalculadoraDeJuros.Presentation.API.dll"]


