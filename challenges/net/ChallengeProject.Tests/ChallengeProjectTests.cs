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
        public void InitConnection()
        {
          _challenge.InitConnection();
        }
    }
}
