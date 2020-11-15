using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ForexAppApi.Services;
using ForexAppApi.Model;

namespace ForexAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForexDataController : ControllerBase
    {
        private readonly IForexDataService _forexDataService;

        public ForexDataController(IForexDataService forexDataService)
        {
            _forexDataService = forexDataService;
        }


        [HttpGet]
        public IEnumerable<ForexDetail> Get()
        {
            return _forexDataService.FindAll();
        }


        // url: api/ForexData/forexDetail
        [HttpPost("forexDetail")]
        public void Post([FromBody] ForexDetail forexDetail)
        {
            _forexDataService.Add(forexDetail);

        }
    }
}
