# Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY . ./

RUN dotnet publish -c Release -o /export

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime

WORKDIR /app

COPY --from=build /export ./

EXPOSE 8080

ENTRYPOINT ["dotnet", "lez11_sr.dll"]