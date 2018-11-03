using HelloWorld.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;
using System;
using System.IO;

namespace HelloWorld.Client
{
    class Program
    {
        private static ServiceProvider serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();

            var writer = serviceProvider
            .GetService<IWriter>();

            var restClient = new RestClient("http://localhost:59207/");
            var request = new RestRequest("api/helloworld");

            IRestResponse response = restClient.Execute(request);
            var content = response.Content;

            writer.Write(content);

            Console.WriteLine("Press enter to exit!!");
            Console.ReadLine();
        }

        private static void RegisterServices()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            var serviceCollection = new ServiceCollection();
            if (configuration["repositoryType"] =="console")
            {
                serviceCollection.AddSingleton<IWriter, ConsoleWriter>();
            }

            serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
