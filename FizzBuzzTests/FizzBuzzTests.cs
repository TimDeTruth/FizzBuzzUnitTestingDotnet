namespace FizzBuzzTests;
using FizzBuzzLibrary;
public class FizzBuzzTests
{
    [Fact]
    public void Given2Result12()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 ", fb.GetResult(2));
    }

    [Fact]
    public void Given4Result12fizz4()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 Fizz 4 ", fb.GetResult(4));
    }

    [Fact]
    public void Given5Result12fizz4buzz()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 Fizz 4 Buzz ", fb.GetResult(5));
    }

    [Fact]
    public void Given15Result12fizz4buzzfizz78fizzbuzz11fizzfizz1314fizzbuzz()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ", fb.GetResult(15));
    }




    [Fact]
    public void GivenMoreThan1000ThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(1001);
        Assert.Throws<Exception>(act);
    }


    [Fact]
    public void GivenNegtativeThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(-11);
        Assert.Throws<Exception>(act);
    }


    [Fact]
    public void GivenZeroThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(0);
        Assert.Throws<Exception>(act);
    }




}