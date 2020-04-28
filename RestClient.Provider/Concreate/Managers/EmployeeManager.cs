using Newtonsoft.Json;
using RestClient.Provider.Abstract;
using RestClient.Provider.Concreate.Base;
using RestClient.Provider.Models;
using RestClient.Provider.Models.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Provider.Concreate.Managers
{
    public class EmployeeManager : BaseManager, IRestService<EmployeeViewModel>
    {
        public async Task<EmployeeViewModel> GetAsync(int id)
        {
            var json = await _httpClient.GetStringAsync(UrlConfigurations.Employee.GetEmployee + id);
            var result = JsonConvert.DeserializeObject<MobileResult>(json);
            return JsonConvert.DeserializeObject<EmployeeViewModel>(result.Data.ToString());
        }

        public async Task<IEnumerable<EmployeeViewModel>> GetAllAsync()
        {
            var json = await _httpClient.GetStringAsync(UrlConfigurations.Employee.GetEmployees);
            var result = JsonConvert.DeserializeObject<MobileResult>(json);
            return JsonConvert.DeserializeObject<IEnumerable<EmployeeViewModel>>(result.Data.ToString());
        }

        public async Task<EmployeeViewModel> PostAsync(EmployeeViewModel entity)
        {

            var json = await _httpClient.PostAsync(UrlConfigurations.Employee.PostEmployee, new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json"));
            var result = JsonConvert.DeserializeObject<MobileResult>(await json.Content.ReadAsStringAsync());
            return JsonConvert.DeserializeObject<EmployeeViewModel>(result.Data.ToString());
        }



        public async Task<EmployeeViewModel> PutAsync(EmployeeViewModel entity)
        {
            var json = await _httpClient.PutAsync(UrlConfigurations.Employee.PutEmployee, new StringContent(JsonConvert.SerializeObject(entity)));
            var result = JsonConvert.DeserializeObject<MobileResult>(await json.Content.ReadAsStringAsync());
            return JsonConvert.DeserializeObject<EmployeeViewModel>(result.Data.ToString());
        }

        
        public async Task<EmployeeViewModel> DeleteAsync(EmployeeViewModel entity)
        {
            var json = await _httpClient.DeleteAsync(UrlConfigurations.Employee.DeleteEmployee + entity.Id);
            var result = JsonConvert.DeserializeObject<MobileResult>(json.ToString());
            return JsonConvert.DeserializeObject<EmployeeViewModel>(result.Result.ToString());
        }
    }
}
