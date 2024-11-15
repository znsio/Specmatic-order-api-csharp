using specmatic_order_api_csharp.models;
using specmatic_order_api_csharp.services;
using Xunit;

namespace specmatic_order_api_csharp.tests
{
    public class MetricsServiceTests
    {
        private readonly MetricService _metricService;

        public MetricsServiceTests()
        {
            _metricService = new MetricService(); // Initialize MetricService
        }

        [Fact]
        public void ActiveUsers_ShouldReturnCorrectUserCount()
        {
            // Arrange
            int expectedUserCount = 1;  // Expected value from DB.UserCount()
            
            // Simulate DB.UserCount() return value (this may require using some test helper if DB is static)
            // For example, if DB.UserCount() is hardcoded, we should mock or simulate the return in a way it gets tested
            // Since DB is static and not mockable, we assume DB.UserCount() will return the expected value
            // Assume DB.UserCount() method is set up elsewhere in the system for testing
            
            // Act
            var result = _metricService.ActiveUsers();

            // Assert
            Assert.Equal(expectedUserCount, result); // Ensure returned count matches the expected value
        }
    }
}