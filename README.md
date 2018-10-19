# NetStandardAnnotationsIssues
Sample projects that show Annotations reference issues with .NET Standard 2.0 libraries

The sample projects are related to this dotnet/standard Issue #450:<br/>
[Add System.ComponentModel.DataAnnotations to .NET Standard](https://github.com/dotnet/standard/issues/450#issuecomment-421625262)

- Scenario1
  - DomainLib is a NetStandard 2.0 library that uses `System.ComponentModel.Annotations`
  - WpfApp is a .NET Framework 4.7.2 project that references DomainLib.
  - DomainLib.Test is a .NET Framework 4.7.2 project that references DomainLib.
- Scenario2
  - DomainLib is a .NET Framework 4.7.2 library that uses `System.ComponentModel.Annotations` and `Microsoft.EntityFrameworkCore` (NuGet via PackageReference).
  - WpfApp is a .NET Framework 4.7.2 project that references DomainLib.
  - DomainLib.Test is a .NET Framework 4.7.2 project that references DomainLib.
  
**Result**

The WpfApp and the UnitTest projects fail during runtime with the error:<br/>
```
Could not load file or assembly 'System.ComponentModel.Annotations, Version=4.2.0.0, Culture=neutral, 
PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies.
```
