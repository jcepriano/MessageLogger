namespace MessageLogger.UnitTests
{
    public class UserTests
    {
        [Fact]
        public void User_Constructor_CreatesObjects()
        {
            User user1 = new User("James", "jcepriano");
            Assert.Equal("James", user1.Name);
            Assert.Equal("jcepriano", user1.UserName);
        }
    }
}