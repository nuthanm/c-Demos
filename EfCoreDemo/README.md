### EFCore Important points

**There are several ways to add ef core libraries into our c# project.**

~~~
Option 1. Add the following efcore libraries using Visual studio nuget UI into your project

Microsoft.Entityframeworkcore.Sqlserver
Microsoft.EntityFrameworkcore.tools
Microsoft.EntityFrameworkcore.design

Option 2: Add the same library using Nuget Package console

Command: install-package Microsoft.Entityframeworkcore.Sqlserver

Option 3: Add the same library using .net core commands

**Without version**
Command: dotnet add package Microsoft.Entityframeworkcore.Sqlserver
**With version**
Command: dotnet add package Microsoft.Entityframeworkcore.Tools --version 1.1.0-msbuild3-final

~~~

2. Create a models
3. Create a DBContext file
4. Run Migration using Nuget Package Console
~~~
Command: Add-Migration <name>
~~~
5. To create a database
~~~
Command: Update-Database
~~~

**Note:** Add-Migration and Update-Database commands are going to use if any changes in models and this has to update in database.
**Models with out data annotations**

~~~
Scaffold-DbContext "<DBConnectionString>" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context <ContextName>
~~~

**Models with data annotations**
~~~
Scaffold-DbContext "<DBConnectionString>" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context <ContextName> -DataAnnotations
~~~

**Entity States for DB Operations**
~~~
Add Operation - Added

Modify/Update Operation - Modified

Delete Opertion - Deleted
~~~
