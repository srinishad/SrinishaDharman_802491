FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Mod_APIGateway/Mod.APIGateway.csproj", "Mod_APIGateway/"]
RUN dotnet restore "Mod_APIGateway/Mod.APIGateway.csproj"
COPY . .
WORKDIR "/src/Mod_APIGateway"
RUN dotnet build "Mod.APIGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mod.APIGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mod.APIGateway.dll"]