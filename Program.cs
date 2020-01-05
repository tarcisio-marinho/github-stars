using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using github_stars.Domain.Entities;
using System.Net.Http.Formatting;
using github_stars.Infra.URLs;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using github_stars.Infra.mongodb;
using MongoDB.Driver;
using System.Linq;


namespace github_stars
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            IMongoClient dbclient;
            IMongoDatabase database;
            dbclient = new MongoClient(URI.Uri);
            database = dbclient.GetDatabase(URI.Collection);
            // using(MainLoop m = new MainLoop()){
            //     m.loop();
            // }
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36");
            var responseTask = await client.GetAsync(GithubApiUrls.Repositories);
            var repos = await responseTask.Content.ReadAsAsync<IList<Repository>>();
            
            var ordered = repos.ToList().OrderByDescending(r => r.StargazersCount).ToList();
            foreach (var repo in repos)
            {
                if (repo.License != null)
                {
                    Console.WriteLine(repo.Name);
                }
            }
        }
    }
}