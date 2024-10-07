using RefuseManagementPortal.Models;
using System.Net;
using System.Net.Http.Json;

namespace RefuseManagementPortal.Service
{
    public class DataBaseConnection
    {
        private readonly HttpClient client = new()
        {
            BaseAddress = new Uri(@"https://guntherrefusedispatchapi.azurewebsites.net/DispatchRecord/")
        };
        public async Task<List<T>> GetRecordAsync<T>(string endPoint)
        {
            var result = await client.GetFromJsonAsync<List<T>>(endPoint) ?? new List<T>();
            return result;
        }
    }
}
