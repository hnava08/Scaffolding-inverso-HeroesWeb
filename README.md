# Scaffolding inverso · HeroesWeb

Práctica guiada **Database First** con Razor Pages, Entity Framework Core y SQL Server (.NET 10).

## Contenido

- Base de datos `HeroesDb` (tablas `Heroes` y `SuperPoderes` con `ON DELETE CASCADE`)
- Ingeniería inversa: `Models` + `Data/HeroesContext`
- CRUD de héroes y superpoderes
- Capturas de entrega en `capturas/`

## Requisitos

- SDK .NET 10
- SQL Server accesible (en este entorno se usó Docker `sql_clase` en `localhost,1433`)

## Configuración

1. Copia `HeroesWeb/appsettings.Development.json` (no se sube al repo) o edita la cadena en `appsettings.json`.
2. Crea la base con el script SQL de la práctica si aún no existe.
3. Ejecuta:

```bash
cd HeroesWeb
dotnet restore
dotnet run --launch-profile http
```

Abre la URL indicada (por ejemplo `http://localhost:5117`) y usa el menú **Héroes** / **Superpoderes**.

## Nota de seguridad

`appsettings.json` del repositorio usa un placeholder de contraseña. La conexión real va en `appsettings.Development.json` (ignorado por git).
