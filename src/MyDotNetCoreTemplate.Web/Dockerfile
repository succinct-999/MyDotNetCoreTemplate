#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/MyDotNetCoreTemplate.Web/MyDotNetCoreTemplate.Web.csproj", "src/MyDotNetCoreTemplate.Web/"]
COPY ["src/MyDotNetCoreTemplate.Infrastructure/MyDotNetCoreTemplate.Infrastructure.csproj", "src/MyDotNetCoreTemplate.Infrastructure/"]
COPY ["src/MyDotNetCoreTemplate.Core/MyDotNetCoreTemplate.Core.csproj", "src/MyDotNetCoreTemplate.Core/"]
RUN dotnet restore "src/MyDotNetCoreTemplate.Web/MyDotNetCoreTemplate.Web.csproj"
COPY . .
WORKDIR "/src/src/MyDotNetCoreTemplate.Web"
RUN dotnet build "MyDotNetCoreTemplate.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyDotNetCoreTemplate.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyDotNetCoreTemplate.Web.dll"]