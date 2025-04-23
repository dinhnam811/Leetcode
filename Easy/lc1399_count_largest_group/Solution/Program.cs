using NUnit.Framework;
public class Solution {
    public int DigitSum(int n) {
        int sum = 0;
        while (n > 0) {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    public int CountLargestGroup(int n) {
        Dictionary<int,int> myDic = new();
        for (int i = 0; i <= n; i++)
        {
            int key = DigitSum(i);
            if (!myDic.ContainsKey(key))
            {
                myDic[key] = 0;
            }
            myDic[key]++;
        }
        int maxCount = myDic.Values.Max();
        return myDic.Values.Count(x => x == maxCount);
        }
}
[TestFixture]
public class CountLargestGroupTest
{
    [Test]
    public void Test_n_equals_13()
    {
        Solution sol = new();
        int result = sol.CountLargestGroup(13);
        Assert.That(result, Is.EqualTo(4));
    }
}



