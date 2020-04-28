namespace RestClient.Provider.Models
{
    public class UrlConfigurations
    {
        public const string MainUrl = "http://mustafadikyar.com/" + "api/";
        public static class Employee
        {
            public const string Controller = MainUrl + "employees/";

            public const string GetEmployees = Controller;
            public const string GetEmployee = Controller + "employee/";
            public const string PostEmployee = Controller + "addemployee/";
            public const string PutEmployee = Controller + "editemployee/";
            public const string DeleteEmployee = Controller + "deleteemployee/";
        }
    }
}
