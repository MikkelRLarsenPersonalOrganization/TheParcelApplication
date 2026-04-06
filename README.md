## How to add new service into src folder
1) go to root folder where sln is located and open PowerShell
2) Enable ExcetionPolicy Bypass via command:
```console
Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass
```
3) Use AddMicroservice script
```console
.\AddMicroservice.ps1 -ProjectName PlaceholderName
```
4) Your new Microservice is now in src folder