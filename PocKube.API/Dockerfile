FROM "mcr.microsoft.com/dotnet/aspnet:8.0-alpine"

RUN apk add --no-cache tzdata icu-libs icu-data-full
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ENV DOTNET_SYSTEM_GLOBALIZATION_PREDEFINED_CULTURES_ONLY=false

WORKDIR /app/PocKube.API
COPY . ./
EXPOSE $DOCKER_EXPOSE_PORT

ENTRYPOINT ["dotnet", "PocKube.API.dll"]