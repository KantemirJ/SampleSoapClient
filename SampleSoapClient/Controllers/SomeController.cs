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
        [HttpGet("Sum")]
        public async Task<IActionResult> gettt()
        {
            ISoapService soapServiceChannel = new SoapServiceClient(SoapServiceClient.EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
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
            IDatabaseManager databaseManagerChannel = new DatabaseManagerClient(DatabaseManagerClient.EndpointConfiguration.BasicHttpBinding_IDatabaseManager_soap);
            var sumResponse = await databaseManagerChannel.InsertDataAsync(new InsertDataRequest()
            {
                Body = new InsertDataRequestBody()
                {
                    data = data
                }
            });
            return Ok(sumResponse.Body.InsertDataResult);
        }
    }
}
