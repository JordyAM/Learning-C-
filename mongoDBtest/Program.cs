// See https://aka.ms/new-console-template for more information
using System;
using MongoDB.Driver; 

namespace mongoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DotNetEnv.Env.Load();
            var mongoCluster = Environment.GetEnvironmentVariable("DATABASE_URL");

            MongoClient dbClient = new MongoClient($"{mongoCluster}");

            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach(var db in dbList)
            {
                Console.WriteLine(db);
            }
        }
    }
}