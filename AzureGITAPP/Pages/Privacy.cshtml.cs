using AzureGITAPP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureGITAPP.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public List<Employee> employeesList = new List<Employee>();
        public List<Employee> GetData()
        {
            List<Employee> employees = new List<Employee>() {
                new Employee(){
                    Id = 1,
                    Name="Employee 1",
                    Department ="Admin",
                    Salary=15000,
                },
                 new Employee(){
                    Id = 2,
                    Name="Employee 2",
                    Department ="Admin",
                    Salary=18000,
                },
            };

            return employees;
        }

        public void OnGet()
        {
            employeesList = GetData();

        }
    }
}