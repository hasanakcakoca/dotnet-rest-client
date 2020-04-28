using RestClient.WebApi.Models;
using RestClient.WebApi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace RestClient.WebApi.Controllers
{
    [RoutePrefix("api/employees")]
    public class EmployeesController : BaseController
    {
        ApiResult result = new ApiResult();

        [Route(""), HttpGet]
        public ApiResult GetEmployees()
        {
            try
            {
                result.Result = true;
                var data = new List<EmployeeViewModel> {
                              new EmployeeViewModel { Id = 1, Name = "Mustafa", Gender = true },
                              new EmployeeViewModel { Id = 2, Name = "Ayşe", Gender = false },
                              new EmployeeViewModel { Id = 3, Name = "Fatma", Gender = false },
                              new EmployeeViewModel { Id = 2, Name = "Murat", Gender = false }
                        };

                result.Data = data;
                result.Message = "Success.";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = $"Error : {ex.Message}";
            }
            return result;
        }

        [Route("employee/{id:int}"), HttpGet]
        public ApiResult GetEmployee(int id)
        {
            try
            {
                result.Result = true;
                result.Data = new EmployeeViewModel { Id = 1, Name = "Mustafa", Gender = true };
                result.Message = "Success.";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = $"Error : {ex.Message}";
            }
            return result;
        }

        [ResponseType(typeof(EmployeeViewModel)), Route("editemployee"), HttpPut]
        public ApiResult PutEmployee([FromBody]EmployeeViewModel model)
        {
            try
            {
                //TO DO: update operation
                result.Result = true;
                result.Data = model;
                result.Message = "Success.";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = $"Error : {ex.Message}";
            }
            return result;
        }

        [ResponseType(typeof(EmployeeViewModel)), Route("addemployee"), HttpPost]
        public ApiResult PostEmployee([FromBody]EmployeeViewModel model)
        {
            try
            {
                //TO DO: add operation
                result.Result = true;
                result.Data = model;
                result.Message = "Success.";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = $"Error : {ex.Message}";
            }
            return result;
        }


        [ResponseType(typeof(ApiResult)), Route("deleteemployee/{id:int}"), HttpDelete]
        public ApiResult DeleteEmployee(int id)
        {
            try
            {
                //TO DO: delete operation
                result.Result = true;
                result.Data = new EmployeeViewModel { Id = 1, Name = "Mustafa", Gender = false };
                result.Message = "Success.";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = $"Error : {ex.Message}";
            }
            return result;
        }
    }
}
