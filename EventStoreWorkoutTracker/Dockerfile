FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EventStoreWorkoutTracker/EventStoreWorkoutTracker.csproj", "EventStoreWorkoutTracker/"]
RUN dotnet restore "EventStoreWorkoutTracker/EventStoreWorkoutTracker.csproj"
COPY . .
WORKDIR "/src/EventStoreWorkoutTracker"
RUN dotnet build "EventStoreWorkoutTracker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EventStoreWorkoutTracker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EventStoreWorkoutTracker.dll"]
