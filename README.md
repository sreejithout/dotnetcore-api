# Dotnet Core Api
## A base dotnet core api solution to learn the fundamentals step by step

1. Based on .NET 5
    - [https://docs.microsoft.com/en-us/dotnet/core/dotnet-five](https://docs.microsoft.com/en-us/dotnet/core/dotnet-five)

2. Created solution with open api(swagger) and docker support

3. In-built logger is used now with **seq** to visualize the logs
    - Seq is a centralized log file with superpowers.
    - [https://datalust.co/seq](https://datalust.co/seq)
    ```batch
    docker pull datalust/seq
    docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest
    ```
## Workflow Library
1. Planing to implement Elsa Workflows library (Just haven't learned it yet. So, keeping it in pipeline.)
- [https://elsa-workflows.github.io/elsa-core/](https://elsa-workflows.github.io/elsa-core/)