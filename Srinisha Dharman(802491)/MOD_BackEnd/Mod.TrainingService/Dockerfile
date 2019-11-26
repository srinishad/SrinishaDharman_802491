FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Mod.TrainingService/Mod.TrainingService.csproj", "Mod.TrainingService/"]
RUN dotnet restore "Mod.TrainingService/Mod.TrainingService.csproj"
COPY . .
WORKDIR "/src/Mod.TrainingService"
RUN dotnet build "Mod.TrainingService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mod.TrainingService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mod.TrainingService.dll"]