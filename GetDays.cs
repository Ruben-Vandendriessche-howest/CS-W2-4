using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace MCT.Function
{
    public class GetDays
    {
        [FunctionName("GetDays")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "days")] HttpRequest req,
            ILogger log)
        {
            string ConnectionString = Environment.GetEnvironmentVariable("ConnectionString");
            SqlConnection sqlConnection = new SqlConnection("");

            return new OkObjectResult("");
        }
    }
}
