FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Mod.Authenticateservice/Mod.Authenticateservice.csproj", "Mod.Authenticateservice/"]
RUN dotnet restore "Mod.Authenticateservice/Mod.Authenticateservice.csproj"
COPY . .
WORKDIR "/src/Mod.Authenticateservice"
RUN dotnet build "Mod.Authenticateservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mod.Authenticateservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mod.Authenticateservice.dll"]