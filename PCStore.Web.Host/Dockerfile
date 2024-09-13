#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["PCStore.Web.Host/PCStore.Web.Host.csproj", "PCStore.Web.Host/"]
COPY ["PCStore.Web.Application/PCStore.Web.Application.csproj", "PCStore.Web.Application/"]
COPY ["PCStore.Web.DataAccess/PCStore.Web.DataAccess.csproj", "PCStore.Web.DataAccess/"]
COPY ["PCStore.Web.Core/PCStore.Web.Core.csproj", "PCStore.Web.Core/"]
RUN dotnet restore "./PCStore.Web.Host/PCStore.Web.Host.csproj"
COPY . .
WORKDIR "/src/PCStore.Web.Host"
RUN dotnet build "./PCStore.Web.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./PCStore.Web.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PCStore.Web.Host.dll"]