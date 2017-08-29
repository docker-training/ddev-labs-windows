param(
    [Parameter(Mandatory=$true)]
    [string] $sa_password,

    [Parameter(Mandatory=$true)]
    [string] $db_name)

# start the service
Write-Verbose 'Starting SQL Server'
start-service MSSQL`$SQLEXPRESS

if($sa_password -ne "-") {
    Write-Verbose 'Changing SA login credentials'
    $sqlcmd = "ALTER LOGIN sa with passowrd='$sa_password'; ALTER LOGIN sa ENABLE;"
    Invoke-Sqlcmd -Query $sqlcmd -ServerInstance ".\SQLEXPRESS"
}

# attach data files if they exist:
$mdfPath = "c:\database\${db_name}_Primary.md"
if ((Test-Path $mdfPath) -eq $true) {
    $sqlcmd = "IF DB_ID('${db_name}') IS NULL BEGIN CREATE DATATBASE ${db_name} ON (FILENAME = N'$mdfPath')"
    $ldfPath = "c:\database\${db_name}_Primary.ldf"
    if((Test-Path $ldfPath) -eq $true) {
        $sqlcmd = "$sqlcmd, (FILENAME = N'$ldfPath')"
    }

    $sqlcmd = "$sqlcmd FOR ATTACH; END"
    Write-Verbose "Invoke-Sqlcmd -Query $($sqlcmd) -ServerInstance '.\SQLEXPRESS'"
    Invoke-Sqlcmd -Query $sqlcmd -ServerInstance ".\SQLEXPRESS"
}

# deploy or upgrade the database:
$SqlPackagePath = 'C:\Program Files (x86)\Microsoft SQL Server\130\DAC\bin\SqlPackage.exe'
& $SqlPackagePath `
    /sf:${db_name}.dacpac `
    /a:Script /op:create.sql /p:CommentOutSetVarDeclarations=true `
    /tsn:.\SQLEXPRESS /tdn:${db_name} /tu:sa /tp:$sa_password

$SqlCmdVars = "DatabaseName=${db_name}", "DefaultFilePrefix=${db_name}", "DefaultDataPath=c:\database\", "DefaultLogPath=c:\database\"
Invoke-Sqlcmd -InputFile create.sql -Variable $SqlCmdVars -Verbose

# TODO - use ServiceMonito.exe when it gets open-sourced (https://github.com/Microsoft/iis-docker/issues/1)
Write-Verbose "Started SQL Server."
while ($true) { Start-Sleep -Seconds 3600 }