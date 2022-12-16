#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["services/saas/NuGet.Config", "services/saas/"]
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["services/saas/host/ONE.SaaSService.HttpApi.Host/ONE.SaaSService.HttpApi.Host.csproj", "services/saas/host/ONE.SaaSService.HttpApi.Host/"]
COPY ["shared/ONE.Shared.Hosting/ONE.Shared.Hosting.csproj", "shared/ONE.Shared.Hosting/"]
COPY ["services/administration/src/ONE.AdministrationService.EntityFrameworkCore/ONE.AdministrationService.EntityFrameworkCore.csproj", "services/administration/src/ONE.AdministrationService.EntityFrameworkCore/"]
COPY ["services/administration/src/ONE.AdministrationService.Domain/ONE.AdministrationService.Domain.csproj", "services/administration/src/ONE.AdministrationService.Domain/"]
COPY ["services/administration/src/ONE.AdministrationService.Domain.Shared/ONE.AdministrationService.Domain.Shared.csproj", "services/administration/src/ONE.AdministrationService.Domain.Shared/"]
COPY ["services/saas/src/ONE.SaaSService.HttpApi/ONE.SaaSService.HttpApi.csproj", "services/saas/src/ONE.SaaSService.HttpApi/"]
COPY ["services/saas/src/ONE.SaaSService.Application.Contracts/ONE.SaaSService.Application.Contracts.csproj", "services/saas/src/ONE.SaaSService.Application.Contracts/"]
COPY ["services/saas/src/ONE.SaaSService.Domain.Shared/ONE.SaaSService.Domain.Shared.csproj", "services/saas/src/ONE.SaaSService.Domain.Shared/"]
COPY ["services/saas/src/ONE.SaaSService.Application/ONE.SaaSService.Application.csproj", "services/saas/src/ONE.SaaSService.Application/"]
COPY ["services/saas/src/ONE.SaaSService.Domain/ONE.SaaSService.Domain.csproj", "services/saas/src/ONE.SaaSService.Domain/"]
COPY ["services/saas/src/ONE.SaaSService.EntityFrameworkCore/ONE.SaaSService.EntityFrameworkCore.csproj", "services/saas/src/ONE.SaaSService.EntityFrameworkCore/"]
RUN dotnet restore "services/saas/host/ONE.SaaSService.HttpApi.Host/ONE.SaaSService.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/saas/host/ONE.SaaSService.HttpApi.Host"
RUN dotnet build "ONE.SaaSService.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ONE.SaaSService.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ONE.SaaSService.HttpApi.Host.dll"]