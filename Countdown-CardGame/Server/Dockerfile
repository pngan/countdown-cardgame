#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Server/Countdown-CardGame.Server.csproj", "Server/"]
COPY ["Client/Countdown-CardGame.Client.csproj", "Client/"]
COPY ["Shared/Countdown-CardGame.Shared.csproj", "Shared/"]
RUN dotnet restore "Server/Countdown-CardGame.Server.csproj"
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "Countdown-CardGame.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Countdown-CardGame.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Countdown-CardGame.Server.dll"]