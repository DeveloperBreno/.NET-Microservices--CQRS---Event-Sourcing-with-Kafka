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
#### create a zoomkeeper_kafka.yml  file and paste this:


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
