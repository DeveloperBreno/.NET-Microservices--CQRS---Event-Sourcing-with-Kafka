# .NET-Microservices--CQRS---Event-Sourcing-with-Kafka
Course author: Sean Campbell

## About the architecture
![Architecture Overview](https://github.com/DeveloperBreno/.NET-Microservices--CQRS---Event-Sourcing-with-Kafka/assets/42100181/f77b4fed-7be9-49e6-97c8-576cd8ea55ed)


## Preparing the environment

### creating a network
`
sudo docker network create --attachable -d bridge mydockernetwork
`
## Prerequisites
### docker
### docker compose
### apahce kafka
#### Use this file "docker-compose.yml" to create a docker container, then open in the same diretory(main directory) and run this command: 
`
sudo docker-compose up -d
`


### to see the networks
`
sudo docker network ls
`
### conteiner mongo
`
docker run -it -d --name mongo-container \
-p 27017:27017 --network mydockernetwork \
--restart always \
-v mongodb_data_container:/data/db \
mongo:latest
`

### SQL Server
`
docker run -d --name sql-container \
--network mydockernetwork \
--restart always \
-e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=$tr0ngS@P@ssw0rd02' -e 'MSSQL_PID=Express' \
-p 1433:1433 mcr.microsoft.com/mssql/server:2017-latest-ubuntu 
`


#### Observation
To tell docker to deploy containers using a docker-compose.yml, use:
`
docker-compose up
`

#### After started debbuging
##### create a user in SQL Server

USE SocialMedia;
GO

IF NOT EXISTS(SELECT *
FROM sys.server_principals
WHERE name = 'SMUser')
BEGIN
	CREATE LOGIN SMUser WITH PASSWORD=N'SmPA$$06500', DEFAULT_DATABASE=SocialMedia
END

IF NOT EXISTS(SELECT *
FROM sys.database_principals
WHERE name = 'SMUser')
BEGIN
	EXEC sp_adduser 'SMUser', 'SMUser', 'db_owner';
END


