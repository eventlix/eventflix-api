FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY src/Eventflix.Api/*.csproj src/Eventflix.Api/
COPY src/Eventflix.Domain/*.csproj src/Eventflix.Domain/
COPY src/Eventflix.Infra/*.csproj src/Eventflix.Infra/
RUN dotnet restore src/Eventflix.Api/Eventflix.Api.csproj

# copy and build app and libraries
COPY src/Eventflix.Api/ src/Eventflix.Api/
COPY src/Eventflix.Domain/ src/Eventflix.Domain/
COPY src/Eventflix.Infra/ src/Eventflix.Infra/
WORKDIR /source/src/Eventflix.Api
RUN dotnet build -c release --no-restore

FROM build AS publish
RUN dotnet publish -c release --no-build -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Eventflix.Api.dll"]
