# Этап сборки
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Копируем все файлы проекта
COPY . .

# Восстанавливаем зависимости
RUN dotnet restore

# Публикуем (сборка в Release)
RUN dotnet publish -c Release -o /app/publish

# Этап запуска
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app

# Копируем собранные файлы из предыдущего этапа
COPY --from=build /app/publish .

# Указываем порт (Render слушает 8080)
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Запуск
ENTRYPOINT ["dotnet", "MyRestApiServer.dll"]