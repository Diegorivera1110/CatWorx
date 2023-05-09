using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        // Code from GetEmployees() in Program.cs
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            return employees;
        }

        async public static Task<List<Employee>> GetFromApi()
        {
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
            }
        }
    }
}
