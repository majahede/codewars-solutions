namespace codewars_solutions.Likes;
using NUnit.Framework;

[TestFixture]
public class SolutionTest
{
    [Test, Description("It should return correct text")]
    public void SampleTest()
    {
        Assert.AreEqual("no one likes this", Solution.Likes(new string[0]));
        Assert.AreEqual("Peter likes this", Solution.Likes(new string[] {"Peter"}));
        Assert.AreEqual("Jacob and Alex like this", Solution.Likes(new string[] {"Jacob", "Alex"}));
        Assert.AreEqual("Max, John and Mark like this", Solution.Likes(new string[] {"Max", "John", "Mark"}));
        Assert.AreEqual("Alex, Jacob and 2 others like this", Solution.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}));
    }

}