#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5001
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./RetornaTaxaDeJuros.Presentation.API/RetornaTaxaDeJuros.Presentation.API.csproj", "./RetornaTaxaDeJuros.Presentation.API/"]
COPY ["./RetornaTaxaDeJuros.Application.BusinessOperations/RetornaTaxaDeJuros.Application.BusinessOperations.csproj", "./RetornaTaxaDeJuros.Application.BusinessOperations/"]
COPY ["./RetornaTaxaDeJuros.Domain.Domain/RetornaTaxaDeJuros.Domain.Domain.csproj", "./RetornaTaxaDeJuros.Domain.Domain/"]
COPY ["./RetornaTaxaDeJuros.Infra.CrossCutting/RetornaTaxaDeJuros.Infra.CrossCutting.csproj", "./RetornaTaxaDeJuros.Infra.CrossCutting/"]
COPY ["./RetornaTaxaDeJuros.Infra.Repository/RetornaTaxaDeJuros.Infra.Repository.csproj", "./RetornaTaxaDeJuros.Infra.Repository/"]
RUN dotnet restore "./RetornaTaxaDeJuros.Presentation.API/RetornaTaxaDeJuros.Presentation.API.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./RetornaTaxaDeJuros.Presentation.API/RetornaTaxaDeJuros.Presentation.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./RetornaTaxaDeJuros.Presentation.API/RetornaTaxaDeJuros.Presentation.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RetornaTaxaDeJuros.Presentation.API.dll"]


