FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["A function that checks character/A function that checks character.csproj", "A function that checks character/"]
RUN dotnet restore "A function that checks character/A function that checks character.csproj"
COPY . .
WORKDIR "/src/A function that checks character"
RUN dotnet build "A function that checks character.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "A function that checks character.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "A function that checks character.dll"]
