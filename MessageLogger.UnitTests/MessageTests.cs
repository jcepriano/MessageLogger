namespace MessageLogger.UnitTests
{
    public class MessageTests
    {
        [Fact]
        public void Message_Constructor_CreatesObjects()
        {
            Message message1 = new Message("Hello");
            Assert.Equal("Hello", message1.Content);
        }
    }
}