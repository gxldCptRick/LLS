FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["LightLinkServerlessAPI/LightLinkServerlessAPI.csproj", "LightLinkAPI/"]
COPY ["LightLinkLibrary/LightLinkLibrary.csproj", "LightLinkAPI/"]
RUN dotnet restore "LightLinkAPI/LightLinkServerlessAPI.csproj"
WORKDIR "/src/LightLinkAPI"
COPY . .
RUN dotnet build "LightLinkServerlessAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "LightLinkServerlessAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LightLinkServerlessAPI.dll"]