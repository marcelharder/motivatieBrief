FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY bin/Release/netcoreapp3.1/publish/ app/
WORKDIR /app

COPY ./wait-for-it.sh /app/wait-for-it.sh
RUN chmod +x /app/wait-for-it.sh

COPY ./DAL/seeding/*.json /app/DAL/seeding/

ENTRYPOINT [ "dotnet", "api.dll" ]