
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data_soruce_mil.models;
using localforsure_rest_api.factory;
using Newtonsoft.Json;
namespace localforsurerestapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestPurchaseController : ControllerBase
    {
        [HttpGet]
        public List<TestPurchaseIntention> GetTestPurchaseIntentions()
        {
            return Factory.GetTestPurhaseIntentionService().GetTestPurchaseIntentions();
        }


        [HttpPost]
        public bool CreateUser([FromBody]string s)
        {
            var res =   JsonConvert.DeserializeObject<TestPurchaseIntention>(s);
            var testPurchaseIntention = new TestPurchaseIntention();
            return Factory.GetTestPurhaseIntentionService().CreateTestPurchaseIntention(testPurchaseIntention);
        }
    }

}
   
