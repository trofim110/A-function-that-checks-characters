using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enter_two_numbers;
namespace Enter_two_numbersTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void  minusOne()
    {
        //arrnge
        string  Value_1="1";
        string Value_2 = "2";
        int result=(-1);
        //act
        Validationofvalues c = new Validationofvalues();
        int actual = c.Compares_characters(ref  Value_1,ref Value_2);
        //assert
        Assert.AreEqual(result,actual);
    }
}