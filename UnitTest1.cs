using Xunit;

namespace CustomerEngagementPlatform
{
    public class UnitTest1
    {
        [Fact]
        public void CustomerName_ShouldNotBeEmpty()
        {
            string customerName = "Anuja";

            Assert.False(string.IsNullOrEmpty(customerName));
        }

        [Fact]
        public void TicketStatus_ShouldBeOpen()
        {
            string status = "Open";

            Assert.Equal("Open", status);
        }

        [Fact]
        public void AdminRole_ShouldBeAdmin()
        {
            string role = "Admin";

            Assert.Equal("Admin", role);
        }
    }
}
