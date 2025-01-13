namespace Part11_Debugging_ErrorHandling_UnitTesting
{

    [TestClass]
public class UnitTest1
{
    [TestMethod]
    public void BinaryTest()
    {
        var binary255 = "11111111";
        var binary255Result = Debugging_ErrorHandling_UnitTesting.GetBitValues(binary255).Sum();
        Assert.AreEqual(255, binary255Result);

        var binary15 = "00001111";
        var binary15Result = Debugging_ErrorHandling_UnitTesting.GetBitValues(binary15).Sum();
        Assert.AreEqual(15, binary15Result);
    }
}

    internal class Assert
    {
        internal static void AreEqual(int v, int binary255Result)
        {
            throw new NotImplementedException();
        }
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}