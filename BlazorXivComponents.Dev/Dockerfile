FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BlazorXivComponents.Dev/BlazorXivComponents.Dev.csproj", "BlazorXivComponents.Dev/"]
COPY ["BlazorXivComponents.Dev.Client/BlazorXivComponents.Dev.Client.csproj", "BlazorXivComponents.Dev.Client/"]
RUN dotnet restore "BlazorXivComponents.Dev/BlazorXivComponents.Dev.csproj"
COPY . .
WORKDIR "/src/BlazorXivComponents.Dev"
RUN dotnet build "./BlazorXivComponents.Dev.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BlazorXivComponents.Dev.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorXivComponents.Dev.dll"]
