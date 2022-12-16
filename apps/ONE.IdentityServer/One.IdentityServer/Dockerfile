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
COPY ["apps/ONE.IdentityServer/One.IdentityServer/ONE.IdentityServer.csproj", "apps/ONE.IdentityServer/One.IdentityServer/"]
COPY ["services/administration/src/ONE.AdministrationService.EntityFrameworkCore/ONE.AdministrationService.EntityFrameworkCore.csproj", "services/administration/src/ONE.AdministrationService.EntityFrameworkCore/"]
COPY ["services/administration/src/ONE.AdministrationService.Domain/ONE.AdministrationService.Domain.csproj", "services/administration/src/ONE.AdministrationService.Domain/"]
COPY ["services/administration/src/ONE.AdministrationService.Domain.Shared/ONE.AdministrationService.Domain.Shared.csproj", "services/administration/src/ONE.AdministrationService.Domain.Shared/"]
COPY ["services/identity/src/ONE.IdentityService.EntityFrameworkCore/ONE.IdentityService.EntityFrameworkCore.csproj", "services/identity/src/ONE.IdentityService.EntityFrameworkCore/"]
COPY ["services/identity/src/ONE.IdentityService.Domain/ONE.IdentityService.Domain.csproj", "services/identity/src/ONE.IdentityService.Domain/"]
COPY ["services/identity/src/ONE.IdentityService.Domain.Shared/ONE.IdentityService.Domain.Shared.csproj", "services/identity/src/ONE.IdentityService.Domain.Shared/"]
COPY ["services/saas/src/ONE.SaaSService.EntityFrameworkCore/ONE.SaaSService.EntityFrameworkCore.csproj", "services/saas/src/ONE.SaaSService.EntityFrameworkCore/"]
COPY ["services/saas/src/ONE.SaaSService.Domain/ONE.SaaSService.Domain.csproj", "services/saas/src/ONE.SaaSService.Domain/"]
COPY ["services/saas/src/ONE.SaaSService.Domain.Shared/ONE.SaaSService.Domain.Shared.csproj", "services/saas/src/ONE.SaaSService.Domain.Shared/"]
COPY ["shared/ONE.Shared.Hosting/ONE.Shared.Hosting.csproj", "shared/ONE.Shared.Hosting/"]
RUN dotnet restore "apps/ONE.IdentityServer/One.IdentityServer/ONE.IdentityServer.csproj"
COPY . .
WORKDIR "/src/apps/ONE.IdentityServer/One.IdentityServer"
RUN dotnet build "ONE.IdentityServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ONE.IdentityServer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ONE.IdentityServer.dll"]