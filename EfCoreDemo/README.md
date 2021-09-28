### EFCore Important points

1. Add the following nugets in your project
~~~
Microsoft.Entityframeworkcore.Sqlserver
Microsoft.EntityFrameworkcore.tools
Microsoft.EntityFrameworkcore.design
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
