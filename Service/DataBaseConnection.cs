using RefuseManagementPortal.Models;
using System.Net;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;

namespace RefuseManagementPortal.Service
{
    public class DataBaseConnection
    {
        private static string uri = "https://guntherrefusedispatchapi.azurewebsites.net/DispatchRecord/";
        private readonly HttpClient client = new()
        {
            BaseAddress = new Uri(uri)
        };
        public async Task<List<T>> GetRecordAsync<T>(string endPoint)
        {
            var result = await client.GetFromJsonAsync<List<T>>(endPoint) ?? new List<T>();
            return result;
        }
    }
}
