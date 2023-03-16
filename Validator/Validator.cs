namespace Validator;

/// <summary>
/// Class <c>Validator</c> validates a password against policy reqs.
/// 1. No whitespace
/// 2. Password >= length 12 with any char
/// 3. Password >= length 7 with cover of at least 3 groups - lowercase, uppercase, digit, special chars
/// </summary>
public class Validator{
    
    private const int LongMinLength = 12;
    private const int MinLength = 7;
    
    public bool IsValid(string password){
       
       if (password is null) throw new ArgumentNullException(nameof(password));

       // any whitespace -> fail
        if (password.Contains(' ')) return false;

        // over 12 chars -> pass
        if (password.Length >= LongMinLength) return true;

        // under 7 chars -> fail
        if (password.Length < MinLength) return false;

        // if between 7-11 chars, at least 3 of 4 conditions -> pass, otherwise fail
        int cover = 0;

        if (password.Any(char.IsUpper)) cover += 1;
        if (password.Any(char.IsLower)) cover += 1;
        if (password.Any(char.IsDigit)) cover += 1;
        if (password.Any(char.IsSymbol)) cover += 1;
        
        return cover >= 3;
   }
}

// etc ->
public class AlwaysTrueValidator : Validator
{
    public new bool IsValid(string password)
    {
        return true;
    }
}
