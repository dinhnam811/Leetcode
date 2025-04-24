using NUnit.Framework;
public class Solution {
    public int CountCompleteSubarrays(int[] nums) {
         int totalUnique = new HashSet<int>(nums).Count;
        int n = nums.Length;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            HashSet<int> seen = new HashSet<int>();
            for (int j = i; j < n; j++)
            {
                seen.Add(nums[j]);
                if (seen.Count == totalUnique)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
    
[TestFixture]
public class CountCompleteSubarraysTest
{
    [Test]
    public void Test_case_1()
    {
        Solution sol = new();
        int[] nums = { 1, 3, 1, 2, 2 };
        int result = sol.CountCompleteSubarrays(nums);
        Assert.That(result, Is.EqualTo(4));
    }
}
