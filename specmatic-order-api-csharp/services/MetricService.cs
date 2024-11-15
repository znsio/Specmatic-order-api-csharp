using specmatic_order_api_csharp.models;
using Microsoft.Extensions.Logging;
namespace specmatic_order_api_csharp.services;
    public class MetricService
    {
        public int ActiveUsers()
        {
            return DB.UserCount();
        }
    }
