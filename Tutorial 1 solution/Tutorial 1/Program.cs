using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tutorial_1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var websiteURL = args[0];
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(websiteURL);

            if (response.IsSuccessStatusCode) {
                var htmlContent = await response.Content.ReadAsStringAsync();

                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+",RegexOptions.IgnoreCase);

                var emailAdresses = regex.Matches(htmlContent);

                foreach (var match in emailAdresses) {
                    Console.WriteLine(match.ToString());
                }
            }


            Console.WriteLine("Hello World!");
            Console.WriteLine("Kiss My Ass World");
            var var1 = "Yo mama";

            Console.WriteLine("Change for dev");
        }

       

    }
}
