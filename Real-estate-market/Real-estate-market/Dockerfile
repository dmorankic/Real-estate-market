#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Real-estate-market/Real-estate-market.csproj", "Real-estate-market/"]
RUN dotnet restore "Real-estate-market/Real-estate-market.csproj"
COPY . .
WORKDIR "/src/Real-estate-market"
RUN dotnet build "Real-estate-market.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Real-estate-market.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Real-estate-market.dll"]