using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;

namespace LeetCodeProblems;

public class EmpDetails
{
    public int id { get; set; } = 0;

    public string employee_name { get; set; } = "";
    public int employee_salary { get; set; } = 0;
    public int employee_age { get; set; } = 0;
    public string profile_image { get; set; } = "";
}
public class EmpDetailsResponse
{
    public string status { get; set; } = "";
    public List<EmpDetails> data { get; set; } = new();
    public string message { get; set; } = "";
}
public partial class LCProblems
{
    public async Task GetApiCall()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("https://dummy.restapiexample.com/api/v1/employees");
        if (response.IsSuccessStatusCode)
        {
            EmpDetailsResponse result = await response.Content.ReadFromJsonAsync<EmpDetailsResponse>();
            foreach (var item in result.data)
            {
                Console.WriteLine($"Id: {item.id}, Name: {item.employee_name}, Salary: {item.employee_salary}, Age: {item.employee_age}, Image: {item.profile_image}");
            }
        }
    }

}