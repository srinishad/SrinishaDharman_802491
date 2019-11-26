FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Mod.TechnologyServices/Mod.TechnologyServices.csproj", "Mod.TechnologyServices/"]
RUN dotnet restore "Mod.TechnologyServices/Mod.TechnologyServices.csproj"
COPY . .
WORKDIR "/src/Mod.TechnologyServices"
RUN dotnet build "Mod.TechnologyServices.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mod.TechnologyServices.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mod.TechnologyServices.dll"]