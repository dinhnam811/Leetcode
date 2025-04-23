
using System;
using NUnit.Framework;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int k = i + 1; k < nums.Length; k++)
            {
                if (nums[i] + nums[k] == target)
                    return new int[] { i, k };
            }
        }
        return new int[] { -1, -1 };
    }
}

[TestFixture]
public class SolutionTests
{
    [Test]
public void TwoSum_FindsCorrectIndices()
{
    var solution = new Solution();
    var result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

    Assert.That(result, Is.EqualTo(new int[] { 0, 1 }));
}
}