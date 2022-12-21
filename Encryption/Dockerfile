FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Encryption/Encryption.csproj", "Encryption/"]
RUN dotnet restore "Encryption/Encryption.csproj"
COPY . .
WORKDIR "/src/Encryption"
RUN dotnet build "Encryption.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Encryption.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Encryption.dll"]
