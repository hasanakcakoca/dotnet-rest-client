using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestClient.WebApi.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
    }
}