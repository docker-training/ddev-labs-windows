FROM microsoft/dotnet:nanoserver
WORKDIR /app
COPY api.csproj .
RUN dotnet restore
COPY . .
ENV ASPNETCORE_URLS="https://*:5000"
EXPOSE 5000
CMD dotnet run
