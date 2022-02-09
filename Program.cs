using ServiceStack.Redis;
using System;

namespace RedisExampleKeyValue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This is a command code, for using into PowerShell in docker
             for created a contaner in docker using:
            docker run --name local-redis -p 6379:6379 -d redis | obs: if doesn't exists redis in your contaner, itself docker will do the download.
            docker ps | For check if created the redis local
            docker exec -it local-redis sh | For you in the redis.
            if you see the '#' you are in.
            check if you are really in the redis serve puts in commandLine ping need to be return PONG
            somes command for check all documents in the redis: redis-cli keys "*" or KEYS *
             */

            var client1 = new Client { Document = "12345", Nome = "Jose" };
            var client2 = new Client { Document = "54321", Nome = "Monalisa" };

            var host = "localhost:6379";
            using (var redisClient = new RedisClient(host))
            {
                redisClient.Set<Client>(client1.key.ToString(), client1);
                redisClient.Set<Client>(client2.key.ToString(), client2);

            }

            Console.WriteLine("Hello World!");
        }
    }
}
