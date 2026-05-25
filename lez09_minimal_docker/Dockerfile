# FASE 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

# COPY *.csproj ./

# RUN dotnet restore

COPY . ./

RUN dotnet publish -c Release -o /export

# FASE 2: Run
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS run

WORKDIR /app

COPY --from=build /export ./

EXPOSE 8080

ENTRYPOINT ["dotnet", "lez09_minimal_docker.dll"]