# dotnetcore-api
A base dotnet core api solution to learn the fundamentals step by step

1. Created solution with open api and docker support


2. Seq is a centralized log file with superpowers.
```batch
docker pull datalust/seq
docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest
```