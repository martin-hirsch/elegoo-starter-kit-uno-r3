FROM mcr.microsoft.com/dotnet/aspnet:7.0-bullseye-slim-arm32v7 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Elegoo.Lesson.2.Blink/Elegoo.Lesson.2.Blink.csproj", "Elegoo.Lesson.2.Blink/"]
RUN dotnet restore "Elegoo.Lesson.2.Blink/Elegoo.Lesson.2.Blink.csproj"
COPY . .
WORKDIR "/src/Elegoo.Lesson.2.Blink"
RUN dotnet build "Elegoo.Lesson.2.Blink.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Elegoo.Lesson.2.Blink.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Elegoo.Lesson.2.Blink.dll"]
