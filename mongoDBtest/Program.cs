// See https://aka.ms/new-console-template for more information
using System;
using MongoDB.Driver; 

namespace mongoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://dbuser:9XWrtOYIy3vm9deS@cluster0.nztui.mongodb.net/?retryWrites=true&w=majority");

            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach(var db in dbList)
            {
                Console.WriteLine(db);
            }
        }
    }
}