namespace Validator;

internal static class Entry
{
    private static void Main(string[] args)
    {
        IValidator v1 = new DefaultValidator();
        v1.IsValid("1234");
        
        IValidator v2 = new AlwaysTrueValidator();
        v2.IsValid("1234");
    }
}