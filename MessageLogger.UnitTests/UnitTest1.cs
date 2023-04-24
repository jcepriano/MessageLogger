using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace MessageLogger.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Message_Constructor_CreatesObjects()
        {
            Message message1 = new Message("Hello");
            Assert.Equal("Hello", message1.Content);
        }
    }
}