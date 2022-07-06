FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["hireguide.Api/hireguide.Api.csproj", "hireguide.Api/"]
RUN dotnet restore "hireguide.Api/hireguide.Api.csproj"
COPY . .
WORKDIR "/src/hireguide.Api"
RUN dotnet build "hireguide.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "hireguide.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "hireguide.Api.dll"]
