using RefuseManagementPortal.Models;
using System.Net.Http.Json;

namespace RefuseManagementPortal.Service
{
    public class DataBaseConnection
    {
        public async Task<List<DispatchRecord>> GetDispatchRecordsAsync(string endPoint)
        {
            HttpClient client = new();
            const string _baseUrl = @"https://guntherrefusedispatchapi.azurewebsites.net/DispatchRecord/";

            client.BaseAddress = new Uri(_baseUrl);

            var result = await client.GetFromJsonAsync<List<DispatchRecord>>(endPoint) ?? new List<DispatchRecord>();
            return result;
        }
    }
}
