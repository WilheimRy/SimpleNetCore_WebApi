using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ForexAppApi.Services;
using ForexAppApi.Model;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;



namespace ForexAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForexDataController : ControllerBase
    {
        private readonly IForexDataService _forexDataService;

        private readonly ILogger _logger;

        public ForexDataController(IForexDataService forexDataService,
                                    ILogger<ForexDataController> logger)
        {
            _forexDataService = forexDataService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ForexDetail> Get()
        {
            return _forexDataService.FindAll();
        }



        // url: api/ForexData/createNewOrder
        [HttpPost("createNewOrder")]
        [Consumes("application/x-www-form-urlencoded")]
        public void Post([FromForm] IFormCollection keyValuePairs)
        {
            foreach (var item in keyValuePairs)
            {
                _logger.LogInformation("key: " + item.Key+", value: "+item.Value);
            }

            var forexDetail = _forexDataService.getForexDetaiObj(keyValuePairs);

            _forexDataService.Add(forexDetail);

        }

    }
}
