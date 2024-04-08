#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["GraphQLTemplate.GraphAPI/GraphQLTemplate.GraphAPI.csproj", "GraphQLTemplate.GraphAPI/"]
COPY ["GraphQLTemplate.Domain/GraphQLTemplate.Domain.csproj", "GraphQLTemplate.Domain/"]
COPY ["GraphQLTemplate.GraphQLQueries/GraphQLTemplate.GraphQLQueries.csproj", "GraphQLTemplate.GraphQLQueries/"]
COPY ["GraphQLTemplate.Services/GraphQLTemplate.Services.csproj", "GraphQLTemplate.Services/"]
RUN dotnet restore "./GraphQLTemplate.GraphAPI/GraphQLTemplate.GraphAPI.csproj"
COPY . .
WORKDIR "/src/GraphQLTemplate.GraphAPI"
RUN dotnet build "./GraphQLTemplate.GraphAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./GraphQLTemplate.GraphAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GraphQLTemplate.GraphAPI.dll"]