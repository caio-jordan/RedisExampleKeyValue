# RedisExampleKeyValue
	         This is a command code, for using into PowerShell in docker
            for created a contaner in docker using:
            docker run --name local-redis -p 6379:6379 -d redis | obs: if doesn't exists redis in your contaner, itself docker will do the download.
            docker ps | For check if created the redis local
            docker exec -it local-redis sh | For you in the redis.
            if you see the '#' you are in.
            check if you are really in the redis serve puts in commandLine ping need to be return PONG
            somes command for check all documents in the redis: redis-cli keys "*" or KEYS *
