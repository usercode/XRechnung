namespace XRechnung;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public class FieldAttribute : Attribute
{
    public FieldAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}
