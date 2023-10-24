using firebase_pruebas.Data.API;
using firebase_pruebas.Data.Models;
using FireSharp.Response;
using Newtonsoft.Json;

namespace firebase_pruebas.Data.Controllers
{
    public class FirebaseController
    {
        APIController api = new APIController();
        public async Task<List<Users>> GetData()
        {
            try
            {
                FirebaseResponse response = await api.client.GetAsync("users");
                Dictionary<string, Users>? userDictionary = JsonConvert.DeserializeObject<Dictionary<string, Users>>(response.Body.ToString());
                List<Users> userList = userDictionary.Values.ToList();
                return userList;
                
            }
            catch (Exception)
            {
                Console.WriteLine("Se ha producido un error");
                return new List<Users>();
            }
        }
    }
}
