FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["modules/EdgeWebApp/EdgeWebApp.csproj", "modules/EdgeWebApp/"]
RUN dotnet restore "modules\EdgeWebApp\EdgeWebApp.csproj"
COPY . .
WORKDIR "/src/modules/EdgeWebApp"
RUN dotnet build "EdgeWebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EdgeWebApp.csproj" -c Release -o /app/publish

FROM base AS final
RUN mkdir \https
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EdgeWebApp.dll"]
