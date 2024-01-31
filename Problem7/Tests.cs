using NUnit.Framework;

namespace Problem7;

public class Tests
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase(1, 2, 3)]
    //// ↓↓↓ More test cases here ↓↓↓

    //// ↑↑↑ More test cases here ↑↑↑
    public void AssertThis(int arg1, int arg2, int expected)
    {
    }
}
