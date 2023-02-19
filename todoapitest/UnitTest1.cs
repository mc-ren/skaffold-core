namespace todoapitest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        const string wordsToSay = "This is what I say";
        var man = new Man(wordsToSay);

        var words = man.Speak();

        Assert.True(words.Any());
    }
}