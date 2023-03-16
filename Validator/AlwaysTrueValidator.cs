namespace Validator;

public class AlwaysTrueValidator : IValidator
{
    public bool IsValid(string password)
    {
        return true;
    }
}