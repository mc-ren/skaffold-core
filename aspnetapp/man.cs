public interface IPerson {
    string Speak();
}

public class Man : IPerson
{
    private readonly string say;

    public Man(string say)
    {
        this.say = say;
    }
    public string Speak()
    {
        return $"The MAN says {say}";
    }
}