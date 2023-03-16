namespace Validator;

/// <summary>
/// Class <c>AlwaysTrueValidator</c> validates a password and always returns true, except for null 
/// </summary>
/// <exception cref="System.ArgumentNullException"/>
public class AlwaysTrueValidator : IValidator
{
    /// <exception cref="System.ArgumentNullException"/>
    public bool IsValid(string password)
    {
        if (password is null) throw new ArgumentNullException(nameof(password));
        
        return true;
    }
}