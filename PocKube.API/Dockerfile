FROM "mcr.microsoft.com/dotnet/aspnet:6.0-alpine"

ARG DOCKER_EXPOSE_PORT
ARG DOTNET_DIST_PATH

RUN apk add --no-cache tzdata icu-libs icu-data-full
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ENV DOTNET_SYSTEM_GLOBALIZATION_PREDEFINED_CULTURES_ONLY=false

WORKDIR /app

COPY $DOTNET_DIST_PATH/ .

EXPOSE $DOCKER_EXPOSE_PORT

ENTRYPOINT [ "dotnet", "treasury.risk.api.auto-assign.dll" ]