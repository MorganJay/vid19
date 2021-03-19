#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["vid19/vid19.csproj", "vid19/"]
RUN dotnet restore "vid19/vid19.csproj"
COPY . .
WORKDIR "/src/vid19"
RUN dotnet build "vid19.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "vid19.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "vid19.dll"]