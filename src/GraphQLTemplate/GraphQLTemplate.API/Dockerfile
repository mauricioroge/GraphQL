#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["GraphQLTemplate.API/GraphQLTemplate.API.csproj", "GraphQLTemplate.API/"]
COPY ["GraphQLTemplate.Domain/GraphQLTemplate.Domain.csproj", "GraphQLTemplate.Domain/"]
COPY ["GraphQLTemplate.GraphQLQueries/GraphQLTemplate.GraphQLQueries.csproj", "GraphQLTemplate.GraphQLQueries/"]
COPY ["GraphQLTemplate.Services/GraphQLTemplate.Services.csproj", "GraphQLTemplate.Services/"]
RUN dotnet restore "./GraphQLTemplate.API/GraphQLTemplate.API.csproj"
COPY . .
WORKDIR "/src/GraphQLTemplate.API"
RUN dotnet build "./GraphQLTemplate.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./GraphQLTemplate.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GraphQLTemplate.API.dll"]