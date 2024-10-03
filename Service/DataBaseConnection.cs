using RefuseManagementPortal.Models;
using System.Net.Http.Json;

namespace RefuseManagementPortal.Service
{
    public class DataBaseConnection
    {
        public async Task<List<DispatchRecord>> GetDispatchRecordsAsync()
        {
            HttpClient client = new();
            const string _baseUrl = @"https://guntherrefusedispatchapi.azurewebsites.net/";
            const string _newsEndpoint = "DispatchRecord";

            client.BaseAddress = new Uri(_baseUrl);

            return await client.GetFromJsonAsync<List<DispatchRecord>>(_newsEndpoint) ?? new List<DispatchRecord>();
        }
    }
}
