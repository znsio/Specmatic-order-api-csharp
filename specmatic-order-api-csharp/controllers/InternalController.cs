
using Microsoft.AspNetCore.Mvc;
using specmatic_order_api_csharp.services;  // Replace with the correct namespace for MetricService

namespace specmatic_order_api_csharp.controllers
{
    // Replace with your actual namespace
    [ApiController]
    [Route("internal")]
    public class InternalController : ControllerBase
    {
        private readonly MetricService _metricService;

        public InternalController(MetricService metricService)
        {
            _metricService = metricService;
        }

        [HttpGet("metrics")]
        public ActionResult<int> Metrics()
        {
            return _metricService.ActiveUsers();
        }
    }
}