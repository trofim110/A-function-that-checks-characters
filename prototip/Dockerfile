FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["prototip/prototip.csproj", "prototip/"]
RUN dotnet restore "prototip/prototip.csproj"
COPY . .
WORKDIR "/src/prototip"
RUN dotnet build "prototip.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "prototip.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "prototip.dll"]
