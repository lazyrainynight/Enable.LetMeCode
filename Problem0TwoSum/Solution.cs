namespace Problem0TwoSum;

public class Solution
{
    public bool TwoSum(IEnumerable<int> nums, int target)
    {
        var memo = new HashSet<int>();

        foreach (int n in nums)
        {
            if (memo.Contains(target - n))
                return true;

            memo.Add(n);
        }

        return false;
    }
}
