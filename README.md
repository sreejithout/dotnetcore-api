# Dotnet Core Api
## .NET 5 api solution to learn the fundamentals step by step

1. [Based on .NET 5](https://docs.microsoft.com/en-us/dotnet/core/dotnet-five)
    - Created solution with open api(swagger) and docker support

2. In-built logger is used now with **seq** to visualize the logs
    - [.NET 5 Default Log](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-5.0)
    - [Logging with iLogger Best Practices](https://blog.rsuter.com/logging-with-ilogger-recommendations-and-best-practices/)
    - Seq is a centralized log file with superpowers.
    - [https://datalust.co/seq](https://datalust.co/seq)
    ```batch
    docker pull datalust/seq
    docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest
    ```
3. Layering
    - Business Logic Layer **dotnetcore-api.BLL**
    - Data Access Layer **dotnetcore-api.DAL**

4. Dependency Injection
    - [built-in DI provider](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0)
    - Here, I'm using [Autofac](https://autofac.readthedocs.io/en/latest/integration/aspnetcore.html)

5. Configurations

## Things todo in pipeline
- [Dapper for ORM](https://github.com/DapperLib/Dapper)
### Package Registry
- [https://docs.microsoft.com/en-us/nuget/hosting-packages/overview](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview)
### Workflow Library
- Planing to implement Elsa Workflows library (Just haven't learned it yet. So, keeping it in pipeline.)
- [https://elsa-workflows.github.io/elsa-core/](https://elsa-workflows.github.io/elsa-core/)
