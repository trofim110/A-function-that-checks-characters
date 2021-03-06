using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enter_two_numbers;

namespace Enter_two_numbersTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void  conditionsMinusUnits() //Если оба из символов не являются буквенными, то вернуть -1
    {
        //arrnge
        string  Value_1="1";
        string Value_2 = "2";
        int result=(-1);

        int a, b;
        a=  Value_1[0];
        b=  Value_1[0];

        //act
        Validationofvalues c = new Validationofvalues();

        int actual = c.Compares_characters(a,b);
        //assert
        Assert.AreEqual(result,actual);
    }
    [TestMethod]
    public void  ZeroСonditions()  //Если оба символа являются буквенными, но находятся в разных регистрах, то вернуть 0
    {
        //arrnge
        string  Value_1="e";
        string Value_2 = "T";
        int result=(0);

        int a, b;
        a=  Value_1[0];
        b=  Value_2[0];

        //act
        Validationofvalues c = new Validationofvalues();
        int actual = c.Compares_characters( a,b);
        //assert
        Assert.AreEqual(result,actual);
    }
    [TestMethod]
    public void  unitСonditions()        //Если оба символа являются буквенными, и находятся в одном регистре, то вернуть 1
    {
        //arrnge
        string  Value_1="e";
        string Value_2 = "r";
        int result=(1);
        int a, b;
        a=  Value_1[0];
        b=  Value_2[0];
        //act
        Validationofvalues c = new Validationofvalues();
        int actual = c.Compares_characters(a,b);
        //assert
        Assert.AreEqual(result,actual);
    }
}