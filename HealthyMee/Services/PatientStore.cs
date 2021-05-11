using HealthyMee.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace HealthyMee.Services
{
    public class PatientStore : IDataStore<Patient>
    {
        static HttpClient client = new HttpClient();

        public Task<bool> AddItemAsync(Patient item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Patient> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Patient>> GetItemsAsync(bool forceRefresh = false)
        {
            List<Patient> patient = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://healthee.azurewebsites.net/api/Patients");
                if (response.IsSuccessStatusCode)
                {
                    var strPatient = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Patient>>(strPatient);
                }
            }
            catch (Exception ex) { 
            
            }
            return patient;
        }

        public Task<bool> UpdateItemAsync(Patient item)
        {
            throw new NotImplementedException();
        }
    }
}
