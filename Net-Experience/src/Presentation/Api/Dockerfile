FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Net-Experience.csproj", "Presentation/Api/Net-Experience.csproj"]
COPY ["../../../Infrastructure/Persistence/Net.Experience.Persistence.csproj","Infrastructure/Persistence/Net.Experience.Persistence.csproj"]
COPY ["../../../Infrastructure/Configuration/Net.Experience.Configuration.csproj","Infrastructure/Configuration/Net.Experience.Configuration.csproj"]
COPY ["../../../Infrastructure/Helpers/Net.Experience.Common.Helpers.csproj","Infrastructure/Helpers/Net.Experience.Common.Helpers.csproj"]
COPY ["../../../Core/Application/Net.Experience.Application.csproj","Core/Application/Net.Experience.Application.csproj"]
COPY ["../../../Core/Domain/Net.Experience.Domain.csproj","Core/Domain/Net.Experience.Domain.csproj"]

RUN dotnet restore "/src/Presentation/Api/Net-Experience.csproj"
COPY . .
WORKDIR "/src/Presentation/Api"
RUN dotnet build "/src/Presentation/Api/Net-Experience.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "/src/Presentation/Api/Net-Experience.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "/app/publish/Net-Experience.dll"]
