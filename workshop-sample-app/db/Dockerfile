FROM microsoft/mssql-server-2016-express-windows
SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop';"]

EXPOSE 1433
VOLUME c:\\database
ENV sa_password 1loop-back2

WORKDIR c:\\init
COPY . .

CMD Initialize-Database.ps1 -sa_password $env:sa_password -db_name ddev -Verbose