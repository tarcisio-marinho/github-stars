using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using github_stars.Application.Services;
using github_stars.Domain.Entities;
using System.Net.Http.Formatting;
using github_stars.Infra.URLs;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.IO;

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
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36");
            var responseTask = await client.GetStreamAsync(GithubApiUrls.Repositories);

            DataContractJsonSerializer serializerStates = new DataContractJsonSerializer(typeof(IList<Repository>));
            var repos = serializerStates.ReadObject(responseTask) as IList<Repository>;
            // var repos = await responseTask.Content.ReadAsAsync<IList<Repository>>();

            foreach (var repo in repos)
            {
                Console.WriteLine(repo);
            }
        }
    }
}