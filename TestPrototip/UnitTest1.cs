using System.Collections.Generic;
using Xunit;



namespace TestPrototip;

static public class UnitTest1
{
    [Fact]
    public static void  Test1()
    {
        // Arrange
        List<char> wordchar = new List<char>() { 'q', 'w', '3' };
        List<char> NOwordchar = new List<char>() { '3' };
        //act
        IsDigitSample.LogicSolution.DeleteLetters(wordchar);
        //Assert:
        Equals(IsDigitSample.LogicSolution.DeleteLetters(wordchar), NOwordchar);
    }

    [Fact]
    public static void  Test2()
    {
        // Arrange


        //act

        //Assert:
    }



}