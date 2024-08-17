#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/AdoptPet.API/AdoptPet.API.csproj", "src/AdoptPet.API/"]
COPY ["src/AdoptPet.Application/AdoptPet.Application.csproj", "src/AdoptPet.Application/"]
COPY ["src/AdoptPet.Domain/AdoptPet.Domain.csproj", "src/AdoptPet.Domain/"]
COPY ["src/Infrastructure/Infrastructure.csproj", "src/Infrastructure/"]
RUN dotnet restore "./src/AdoptPet.API/AdoptPet.API.csproj"
COPY . .
WORKDIR "/src/src/AdoptPet.API"
RUN dotnet build "./AdoptPet.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AdoptPet.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdoptPet.API.dll"]