using Xunit;

namespace TestPrototip;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        [Test("t5qr33d56q3", "6 - 1, 5 - 2, 3 - 3")]
        [TestCase("t5qr33d56q31", "6 - 1, 5 - 2, 3 - 3, 1 - 1")]
    }
}