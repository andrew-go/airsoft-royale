FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BattleVirusRest/BattleVirusRest.csproj", "BattleVirusRest/"]
RUN dotnet restore "BattleVirusRest/BattleVirusRest.csproj"
COPY . .
WORKDIR "/src/BattleVirusRest"
RUN dotnet build "BattleVirusRest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BattleVirusRest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BattleVirusRest.dll"]
