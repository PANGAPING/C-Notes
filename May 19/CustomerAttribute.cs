[MyAttribute("Dengweihao", "10")]
class SomeClass
{
}


[AttributeUsage(AttributeTargets.All)]
public class MyAttribute : Attribute
{
    private string name;
    private string level;

    public MyAttribute(string name, string level)
    {
        this.name = name;
        this.level = level;
    }
}