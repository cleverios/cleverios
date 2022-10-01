namespace Core.Tests;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void TestMethodCalculateResult()
    {
        Assert.AreEqual(2, Calculate.CalculateResult(1, 1));
    }
}