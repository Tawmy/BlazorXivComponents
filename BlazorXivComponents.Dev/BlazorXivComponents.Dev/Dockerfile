FROM mcr.microsoft.com/dotnet/aspnet:10.0-preview AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0-preview AS build

RUN apt update -y
RUN apt upgrade -y
RUN apt install nodejs npm -y
RUN npm install -g pnpm

ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BlazorXivComponents.Dev/BlazorXivComponents.Dev/BlazorXivComponents.Dev.csproj", "BlazorXivComponents.Dev/BlazorXivComponents.Dev/"]
COPY ["BlazorXivComponents.Dev/BlazorXivComponents.Dev.Client/BlazorXivComponents.Dev.Client.csproj", "BlazorXivComponents.Dev/BlazorXivComponents.Dev.Client/"]
RUN dotnet restore "BlazorXivComponents.Dev/BlazorXivComponents.Dev/BlazorXivComponents.Dev.csproj"
COPY . .

WORKDIR "/src/BlazorXivComponents"
RUN pnpm install

WORKDIR "/src/BlazorXivComponents.Dev/BlazorXivComponents.Dev"
RUN dotnet build "./BlazorXivComponents.Dev.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BlazorXivComponents.Dev.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorXivComponents.Dev.dll"]
