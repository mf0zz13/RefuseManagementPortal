using RefuseManagementPortal.Models;
using System.Net.Http.Json;

namespace RefuseManagementPortal.Service
{
    public class DataBaseConnection
    {
        public async Task<List<Test>> GetDispatchRecords()
        {
            HttpClient client = new();
            const string _baseUrl = @"https://guntherrefusedispatchapi.azurewebsites.net/";
            const string _newsEndpoint = "DispatchRecord";

            client.BaseAddress = new Uri(_baseUrl);

            var result = await client.GetFromJsonAsync<List<Test>>(_newsEndpoint);
            return result;
        }
    }
}
