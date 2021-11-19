#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SnQMenu.AspMvc/SnQMenu.AspMvc.csproj", "SnQMenu.AspMvc/"]
COPY ["SnQMenu.Adapters/SnQMenu.Adapters.csproj", "SnQMenu.Adapters/"]
COPY ["SnQMenu.Logic/SnQMenu.Logic.csproj", "SnQMenu.Logic/"]
COPY ["SnQMenu.Contracts/SnQMenu.Contracts.csproj", "SnQMenu.Contracts/"]
COPY ["CommonBase/CommonBase.csproj", "CommonBase/"]
COPY ["SnQMenu.Transfer/SnQMenu.Transfer.csproj", "SnQMenu.Transfer/"]
RUN dotnet restore "SnQMenu.AspMvc/SnQMenu.AspMvc.csproj"
COPY . .
WORKDIR "/src/SnQMenu.AspMvc"
RUN dotnet build "SnQMenu.AspMvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SnQMenu.AspMvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SnQMenu.AspMvc.dll"]
