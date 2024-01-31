using NUnit.Framework;

namespace Problem0TwoSum;

public class Tests
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new[] { 2, 7, 11, 15 }, 18, true)]
    [TestCase(new[] { 3, 2, 4 }, 6, true)]
    [TestCase(new[] { 3, 3 }, 6, true)]
    [TestCase(new[] { 3, 4 }, 6, false)]
    //// ↓↓↓ More test cases here ↓↓↓

    //// ↑↑↑ More test cases here ↑↑↑
    public void AssertThis(
        IEnumerable<int> nums,
        int target,
        bool expected)
    {
        Assert.That(_solution.TwoSum(nums, target), Is.EqualTo(expected));
    }
}
