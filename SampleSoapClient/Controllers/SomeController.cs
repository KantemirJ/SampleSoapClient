using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using ServiceReference2;

namespace SampleSoapClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {
        ISoapService soapServiceChannel = new SoapServiceClient(SoapServiceClient.EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
        IDatabaseManager databaseManagerChannel = new DatabaseManagerClient(DatabaseManagerClient.EndpointConfiguration.BasicHttpBinding_IDatabaseManager_soap);
        [HttpGet("Sum")]
        public async Task<IActionResult> gettt()
        {
            var sumResponse = await soapServiceChannel.SumAsync(new SumRequest()
            {
                Body = new SumRequestBody()
                {
                    num1 = 2,
                    num2 = 3
                }
            });
            return Ok(sumResponse.Body.SumResult);
        }
        [HttpPost("Insert")]
        public async Task<IActionResult> posttt(Employee data)
        {
            var insertDataResponse = await databaseManagerChannel.InsertDataAsync(new InsertDataRequest()
            {
                Body = new InsertDataRequestBody()
                {
                    data = data
                }
            });
            return Ok(insertDataResponse.Body.InsertDataResult);
        }
        [HttpGet("GetByName")]
        public async Task<IActionResult> getByName(string name)
        {
            var getDataByNameResponse = await databaseManagerChannel.GetDataByNameAsync(new GetDataByNameRequest()
            {
                Body = new GetDataByNameRequestBody()
                {
                    name = name
                }
            });
            return Ok(getDataByNameResponse.Body.GetDataByNameResult);
        }
        [HttpGet("GetByDepartment")]
        public async Task<IActionResult> getByDepartment(string department)
        {
            var getDataByDepartmentResponse = await databaseManagerChannel.GetDataByDepartmentAsync(new GetDataByDepartmentRequest()
            {
                Body = new GetDataByDepartmentRequestBody()
                {
                    department = department
                }
            });
            return Ok(getDataByDepartmentResponse.Body.GetDataByDepartmentResult);
        }
    }
}
