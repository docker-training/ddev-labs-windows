Remove-Item -Force -Recurse -ErrorAction SilentlyContinue -Path G:/obj;
Remove-Item -Force -Recurse -ErrorAction SilentlyContinue -Path G:/bin;
cp -r -Force c:/app/obj .
dotnet watch run
