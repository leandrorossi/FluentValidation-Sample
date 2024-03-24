FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["FluentValidation-Sample/FluentValidation-Sample.csproj", "FluentValidation-Sample/"]
RUN dotnet restore "./FluentValidation-Sample/./FluentValidation-Sample.csproj"
COPY . .
WORKDIR "/src/FluentValidation-Sample"
RUN dotnet build "./FluentValidation-Sample.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./FluentValidation-Sample.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FluentValidation-Sample.dll"]