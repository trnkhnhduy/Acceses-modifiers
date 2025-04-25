using System;
public class AccessModifiersExample
{
    // Public: Có thể truy cập từ bất kỳ đâu
    public string PublicProperty { get; set; }

    // Private: Chỉ có thể truy cập từ lớp này
    private string privateField;

    // Protected: Chỉ có thể truy cập từ lớp này và lớp con
    protected string protectedField;

    // Internal: Chỉ có thể truy cập từ cùng một assembly
    internal string internalField;

    // Protected Internal: Có thể truy cập từ cùng một assembly và lớp con
    protected internal string protectedInternalField;

    public AccessModifiersExample()
    {
        PublicProperty = "Public Value";
        privateField = "Private Value";
        protectedField = "Protected Value";
        internalField = "Internal Value";
        protectedInternalField = "Protected Internal Value";
    }

    public void DisplayValues()
    {
        Console.WriteLine($"Public: {PublicProperty}");
        Console.WriteLine($"Private: {privateField}");
        Console.WriteLine($"Protected: {protectedField}");
        Console.WriteLine($"Internal: {internalField}");
        Console.WriteLine($"Protected Internal: {protectedInternalField}"); // tất cả đều hợp lệ vì nằm trong 1 lớp
    }
}

public class DerivedClass : AccessModifiersExample
{
    public void ShowProtectedValues()
    {
        // Truy cập được protectedField và protectedInternalField
        Console.WriteLine($"Protected from Derived: {protectedField}");
        Console.WriteLine($"Protected Internal from Derived: {protectedInternalField}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AccessModifiersExample example = new AccessModifiersExample();
        example.DisplayValues();

        DerivedClass derived = new DerivedClass();
        derived.ShowProtectedValues();

        // Console.WriteLine(example.privateField); // Lỗi
    }
}