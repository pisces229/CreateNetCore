## Marketplace
> https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp <br>
> https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer <br>
> 

## Nuget
> https://www.nuget.org/ <br>
> dotnet add package PackageName --version 0.0.0 <br>
> 

## Create
```bash
dotnet new -l 
dotnet new web --help 
dotnet new web -f netcoreapp3.1 
dotnet new console --help 
dotnet new console -f netcoreapp3.1 
dotnet new classlib --help 
dotnet new classlib -f netcoreapp3.1 
dotnet new nunit --help 
dotnet new nunit -f netcoreapp3.1 
dotnet add reference ../ProjectName/ProjectName.csproj 
```

## Debug
```bash
dotnet run --configuration Debug
dotnet run --configuration Debug --launch-profile {profile-name}
dotnet run --launch-profile {profile-name}

dotnet ./{Project}/bin/Debug/{Project}.exe --configuration Debug
dotnet ./{Project}/bin/Debug/{Project}.exe --configuration Debug --launch-profile {profile-name}
dotnet ./{Project}/bin/Debug/{Project}.exe --launch-profile {profile-name}
```

## Test
> settings.json add "dotnet-test-explorer.testProjectPath": "Test*"

