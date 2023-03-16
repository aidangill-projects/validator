namespace Validator;

internal static class Entry
{
    private static void Main(string[] args)
    {
        DefaultValidator v = new DefaultValidator();
        v.IsValid("1234");
    }
}