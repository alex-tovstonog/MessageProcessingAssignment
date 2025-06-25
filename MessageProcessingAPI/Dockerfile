FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["MessageProcessingAPI.csproj", "./"]
RUN dotnet restore "MessageProcessingAPI.csproj"

COPY . .
RUN dotnet publish "MessageProcessingAPI.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8888

ENTRYPOINT ["dotnet", "MessageProcessingAPI.dll"]
