using System;
using ChallengeProject;
using Xunit;

namespace ChallengeProject.Tests
{
    public class ChallengeTests
    {
        private readonly Challenge _challenge;

        public ChallengeTests()
        {
            _challenge = new Challenge();
        }



        [Fact]
        public void ApplicationInsightsTest()
        {
            var result = _challenge.AddCustomEventUsingApplicationInsights();

            Assert.True(result, $"Result should be true");
        }
    }
}
