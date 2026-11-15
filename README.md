# LiquidCast

Windows-прототип самостоятельной стрим-студии в стиле Liquid Glass.

## Запуск

```powershell
dotnet run --project LiquidCast.csproj
```

## Сборка

```powershell
dotnet publish LiquidCast.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

## Сборка через GitHub Actions

Workflow находится в `.github/workflows/build-windows.yml`. Загрузите папку проекта в GitHub, откройте вкладку **Actions**, выберите **Build LiquidCast for Windows** и нажмите **Run workflow**. После успешной сборки скачайте artifact `LiquidCast-Windows-x64`; внутри будет `LiquidCast.exe`.

Прототип содержит рабочую оболочку студии: сцены, источники, предпросмотр, чат, профиль, микшер и управление эфиром. Следующий слой подключает Windows Graphics Capture, WASAPI, FFmpeg/RTMP, OAuth и виртуальную камеру.
