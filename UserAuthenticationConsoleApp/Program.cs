using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string userId = "886983f3-52d8-47a0-bdc4-425877900d1f";
            var user = await GetUserByIdAsync(userId);
            if (user != null)
            {
                Console.WriteLine($"User ID: {user.Id}");
                Console.WriteLine($"User Name: {user.UserName}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Forename: {user.Forename}");
                Console.WriteLine($"Surname: {user.Surname}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        static async Task<UserDto> GetUserByIdAsync(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7265/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync($"api/user/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<UserDto>(json);
                }
                return null;
            }
        }
    }

    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}

