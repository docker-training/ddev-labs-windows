FROM microsoft/dotnet:nanoserver
WORKDIR /app
COPY api.csproj .
RUN dotnet restore
COPY . .
CMD dotnet run
