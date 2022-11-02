##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
#WORKDIR /app
#
#FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#WORKDIR /src
#COPY ["services/saas/NuGet.Config", "services/saas/"]
#COPY ["services/administration/NuGet.Config", "services/administration/"]
#COPY ["services/identity/NuGet.Config", "services/identity/"]
#COPY ["shared/Tasky.DbMigrator/ONE.DbMigrator.csproj", "shared/ONE.DbMigrator/"]
#COPY ["services/saas/src/ONE.SaaS.Application.Contracts/ONE.SaaS.Application.Contracts.csproj", "services/saas/src/ONE.SaaS.Application.Contracts/"]
#COPY ["services/saas/src/ONE.SaaS.Domain.Shared/ONE.SaaS.Domain.Shared.csproj", "services/saas/src/ONE.SaaS.Domain.Shared/"]
#COPY ["shared/ONE.Microservice.Shared/ONE.Microservice.Shared.csproj", "shared/ONE.Microservice.Shared/"]
#COPY ["services/administration/src/ONE.Administration.EntityFrameworkCore/ONE.Administration.EntityFrameworkCore.csproj", "services/administration/src/ONE.Administration.EntityFrameworkCore/"]
#COPY ["services/administration/src/ONE.Administration.Domain/ONE.Administration.Domain.csproj", "services/administration/src/ONE.Administration.Domain/"]
#COPY ["services/administration/src/ONE.Administration.Domain.Shared/ONE.Administration.Domain.Shared.csproj", "services/administration/src/ONE.Administration.Domain.Shared/"]
#COPY ["shared/ONE.Hosting.Shared/ONE.Hosting.Shared.csproj", "shared/ONE.Hosting.Shared/"]
#COPY ["services/identity/src/ONE.IdentityService.Application.Contracts/ONE.IdentityService.Application.Contracts.csproj", "services/identity/src/ONE.IdentityService.Application.Contracts/"]
#COPY ["services/identity/src/ONE.IdentityService.Domain.Shared/ONE.IdentityService.Domain.Shared.csproj", "services/identity/src/ONE.IdentityService.Domain.Shared/"]
#COPY ["services/saas/src/ONE.SaaS.EntityFrameworkCore/ONE.SaaS.EntityFrameworkCore.csproj", "services/saas/src/ONE.SaaS.EntityFrameworkCore/"]
#COPY ["services/saas/src/ONE.SaaS.Domain/ONE.SaaS.Domain.csproj", "services/saas/src/ONE.SaaS.Domain/"]
#COPY ["services/identity/src/ONE.IdentityService.EntityFrameworkCore/ONE.IdentityService.EntityFrameworkCore.csproj", "services/identity/src/ONE.IdentityService.EntityFrameworkCore/"]
#COPY ["services/identity/src/ONE.IdentityService.Domain/ONE.IdentityService.Domain.csproj", "services/identity/src/ONE.IdentityService.Domain/"]
#COPY ["services/administration/src/ONE.Administration.Application.Contracts/ONE.Administration.Application.Contracts.csproj", "services/administration/src/ONE.Administration.Application.Contracts/"]
#RUN dotnet restore "shared/ONE.DbMigrator/ONE.DbMigrator.csproj"
#COPY . .
#WORKDIR "/src/shared/ONE.DbMigrator"
#RUN dotnet build "ONE.DbMigrator.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "ONE.DbMigrator.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "ONE.DbMigrator.dll"]