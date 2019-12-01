using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using github_stars.Application.Services;
using github_stars.Domain.Entities;
using System.Net.Http.Formatting;
using github_stars.Infra.URLs;

namespace github_stars
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // using(MainLoop m = new MainLoop()){
            //     m.loop();
            // }
            HttpClient client = new HttpClient();
            var responseTask = await client.GetAsync(GithubApiUrls.Repositories);
            
            var repos = await responseTask.Content.ReadAsAsync<List<Repository>>();

            foreach (var repo in repos)
            {
                Console.WriteLine(repo.Stargazers_count);
            }
        }
    }
}