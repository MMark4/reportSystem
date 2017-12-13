namespace migrations
{
    using System;
    using System.Linq;
    using System.Reflection;
    using DbUp;
    using Microsoft.Extensions.Configuration;

    class Program
    {
        static void Main(string[] args)
        {
            var config =  new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var conectionStrings = config.GetSection("ConnectionStrings");

            var upgrader = DeployChanges.To
                    .SqlDatabase(conectionStrings["DefaultConnection:"])
                    .WithScriptsFromFileSystem(AppDomain.CurrentDomain.BaseDirectory + "scripts/*.sql")
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();                
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
        }
    }
}