# Track
Sample ASP.NET MVC 5 application, demonstrating a layered application architecture.

Technologies
------------
* ASP.NET MVC 5
* EF 6 Code First 
* AutoMapper
* Autofac
* Twitter Bootstrap
* jQuery

Patterns & Practices
---------------------
* Domain Driven Design (DDD)
* Repository Pattern & Generic Repository
* Unit of Work 
* Dependency Injection

Running the Application
-----------------------

1. Open the solution in Visual Studio 2017. Build the solution to install Nuget packages.(This will automatically restore Nuget packages.)
2. Create the ConnectionStringsSecrets.config file inside Track.Web project and edit it as folows:
```
<connectionStrings> 
	<add name="TrackEntities" connectionString="Data Source=MyServer;Initial Catalog=TrackDb;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```
3. Run the application
