FROM "mcr.microsoft.com/dotnet/aspnet:8.0-alpine"

RUN apk add --no-cache tzdata icu-libs icu-data-full
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ENV DOTNET_SYSTEM_GLOBALIZATION_PREDEFINED_CULTURES_ONLY=false

WORKDIR /app
EXPOSE 9001
ENTRYPOINT [ "dotnet", "PocKube.API.dll" ]

RUN apk add --no-cache tzdata

COPY . .