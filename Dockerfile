#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["CommanderWebAPI.csproj", "."]
RUN dotnet restore "./CommanderWebAPI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "CommanderWebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CommanderWebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CommanderWebAPI.dll"]

#FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
#ENV PATH $PATH:/root/.dotnet/tools
#RUN dotnet tool install -g dotnet-ef --version 3.1.1