#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["GentleExpress.API/GentleExpress.API.csproj", "GentleExpress.API/"]
COPY ["GentleExpress.Models/GentleExpress.Models.csproj", "GentleExpress.Models/"]
COPY ["GentleExpress.Services.EFCore/GentleExpress.Services.EFCore.csproj", "GentleExpress.Services.EFCore/"]
COPY ["GentleExpress.Repositories.EfCore/GentleExpress.Repositories.EfCore.csproj", "GentleExpress.Repositories.EfCore/"]
COPY ["GentleExpress.Common.EfCore/GentleExpress.Common.EfCore.csproj", "GentleExpress.Common.EfCore/"]
COPY ["GentleExpress.Repositories.Abstraction/GentleExpress.Repositories.Abstraction.csproj", "GentleExpress.Repositories.Abstraction/"]
COPY ["GentleExpress.Services.Abstraction/GentleExpress.Services.Abstraction.csproj", "GentleExpress.Services.Abstraction/"]
RUN dotnet restore "./GentleExpress.API/GentleExpress.API.csproj"
COPY . .
WORKDIR "/src/GentleExpress.API"
RUN dotnet build "./GentleExpress.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./GentleExpress.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GentleExpress.API.dll"]