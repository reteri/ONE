#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["services/identity/NuGet.Config", "services/identity/"]
COPY ["services/saas/NuGet.Config", "services/saas/"]
COPY ["services/administration/host/ONE.AdministrationService.HttpApi.Host/ONE.AdministrationService.HttpApi.Host.csproj", "services/administration/host/ONE.AdministrationService.HttpApi.Host/"]
COPY ["shared/ONE.Shared.Hosting/ONE.Shared.Hosting.csproj", "shared/ONE.Shared.Hosting/"]
COPY ["services/identity/src/ONE.IdentityService.Application.Contracts/ONE.IdentityService.Application.Contracts.csproj", "services/identity/src/ONE.IdentityService.Application.Contracts/"]
COPY ["services/identity/src/ONE.IdentityService.Domain.Shared/ONE.IdentityService.Domain.Shared.csproj", "services/identity/src/ONE.IdentityService.Domain.Shared/"]
COPY ["services/identity/src/ONE.IdentityService.EntityFrameworkCore/ONE.IdentityService.EntityFrameworkCore.csproj", "services/identity/src/ONE.IdentityService.EntityFrameworkCore/"]
COPY ["services/identity/src/ONE.IdentityService.Domain/ONE.IdentityService.Domain.csproj", "services/identity/src/ONE.IdentityService.Domain/"]
COPY ["services/saas/src/ONE.SaaSService.Application.Contracts/ONE.SaaSService.Application.Contracts.csproj", "services/saas/src/ONE.SaaSService.Application.Contracts/"]
COPY ["services/saas/src/ONE.SaaSService.Domain.Shared/ONE.SaaSService.Domain.Shared.csproj", "services/saas/src/ONE.SaaSService.Domain.Shared/"]
COPY ["services/administration/src/ONE.AdministrationService.HttpApi/ONE.AdministrationService.HttpApi.csproj", "services/administration/src/ONE.AdministrationService.HttpApi/"]
COPY ["services/administration/src/ONE.AdministrationService.Application.Contracts/ONE.AdministrationService.Application.Contracts.csproj", "services/administration/src/ONE.AdministrationService.Application.Contracts/"]
COPY ["services/administration/src/ONE.AdministrationService.Domain.Shared/ONE.AdministrationService.Domain.Shared.csproj", "services/administration/src/ONE.AdministrationService.Domain.Shared/"]
COPY ["services/administration/src/ONE.AdministrationService.Application/ONE.AdministrationService.Application.csproj", "services/administration/src/ONE.AdministrationService.Application/"]
COPY ["services/administration/src/ONE.AdministrationService.Domain/ONE.AdministrationService.Domain.csproj", "services/administration/src/ONE.AdministrationService.Domain/"]
COPY ["services/administration/src/ONE.AdministrationService.EntityFrameworkCore/ONE.AdministrationService.EntityFrameworkCore.csproj", "services/administration/src/ONE.AdministrationService.EntityFrameworkCore/"]
RUN dotnet restore "services/administration/host/ONE.AdministrationService.HttpApi.Host/ONE.AdministrationService.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/administration/host/ONE.AdministrationService.HttpApi.Host"
RUN dotnet build "ONE.AdministrationService.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ONE.AdministrationService.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ONE.AdministrationService.HttpApi.Host.dll"]