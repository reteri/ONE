#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["services/identity/NuGet.Config", "services/identity/"]
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["services/identity/host/ONE.IdentityService.HttpApi.Host/ONE.IdentityService.HttpApi.Host.csproj", "services/identity/host/ONE.IdentityService.HttpApi.Host/"]
COPY ["shared/ONE.Shared.Hosting/ONE.Shared.Hosting.csproj", "shared/ONE.Shared.Hosting/"]
COPY ["services/administration/src/ONE.AdministrationService.EntityFrameworkCore/ONE.AdministrationService.EntityFrameworkCore.csproj", "services/administration/src/ONE.AdministrationService.EntityFrameworkCore/"]
COPY ["services/administration/src/ONE.AdministrationService.Domain/ONE.AdministrationService.Domain.csproj", "services/administration/src/ONE.AdministrationService.Domain/"]
COPY ["services/administration/src/ONE.AdministrationService.Domain.Shared/ONE.AdministrationService.Domain.Shared.csproj", "services/administration/src/ONE.AdministrationService.Domain.Shared/"]
COPY ["services/identity/src/ONE.IdentityService.HttpApi/ONE.IdentityService.HttpApi.csproj", "services/identity/src/ONE.IdentityService.HttpApi/"]
COPY ["services/identity/src/ONE.IdentityService.Application.Contracts/ONE.IdentityService.Application.Contracts.csproj", "services/identity/src/ONE.IdentityService.Application.Contracts/"]
COPY ["services/identity/src/ONE.IdentityService.Domain.Shared/ONE.IdentityService.Domain.Shared.csproj", "services/identity/src/ONE.IdentityService.Domain.Shared/"]
COPY ["services/identity/src/ONE.IdentityService.Application/ONE.IdentityService.Application.csproj", "services/identity/src/ONE.IdentityService.Application/"]
COPY ["services/identity/src/ONE.IdentityService.Domain/ONE.IdentityService.Domain.csproj", "services/identity/src/ONE.IdentityService.Domain/"]
COPY ["services/identity/src/ONE.IdentityService.EntityFrameworkCore/ONE.IdentityService.EntityFrameworkCore.csproj", "services/identity/src/ONE.IdentityService.EntityFrameworkCore/"]
RUN dotnet restore "services/identity/host/ONE.IdentityService.HttpApi.Host/ONE.IdentityService.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/identity/host/ONE.IdentityService.HttpApi.Host"
RUN dotnet build "ONE.IdentityService.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ONE.IdentityService.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ONE.IdentityService.HttpApi.Host.dll"]