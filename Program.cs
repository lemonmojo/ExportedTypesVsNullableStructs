foreach (var type in System.Reflection.Assembly.GetExecutingAssembly().ExportedTypes) {
	Console.WriteLine($"{type.Name}");
}

public struct StructTest
{
    // TODO: Uncommenting this makes Assembly.ExportedTypes throw
    public static readonly StructTest? ReadOnlyField = null;
    
    // TODO: Uncommenting this makes Assembly.ExportedTypes throw
    // public static StructTest? Field = new StructTest();
    
    // TODO: Uncommenting this makes Assembly.ExportedTypes throw
    // public static StructTest? Property { get; set; } = null;
}

public class StructTestClass
{
    // This is fine
    public static readonly StructTest? ReadOnlyField = null;
    
    // This is fine
    public static StructTest? Field = new StructTest();
    
    // This is fine
    public static StructTest? Property { get; set; } = null;
}

public struct ValueTypeTest
{
    // This is fine
    public static readonly int? ReadOnlyField = null;

    // This is fine
    public static int? Field = 0;
    
    // This is fine
    public static int? Property { get; set; } = null;
}