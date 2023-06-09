namespace ValidatorTests;

public class DefaultValidatorTests
{
    private readonly string[] _valid = {
        "P@ssword123",
        "!2Sh0rT^",
        "3chartypeS",
        "3chartype$",
        "ONECHARTYPEBUTLONG",
        "onchartypebutlong",
        "00000000000000000",
        "'`~!@#$%^&*()-=_+/?{|}"
    };
    
    private readonly string[] _invalid = {
        "2Sh0rT",
        "onechartype",
        "ONECHARTYPE",
        "123456789",
        "'`~=_+/?{|}",
        "2cchartypes",
        "2CHARCTYPES",
        "WhiteSp !2"
    };

    private Validator.DefaultValidator? _v;

    [SetUp]
    public void Setup()
    {
        _v = new Validator.DefaultValidator();
    }
    
    [Test]
    public void TestNull()
    {
        try
        {
            _v!.IsValid(null!);
        }
        catch (ArgumentNullException ex)
        {
            Assert.Pass();
        }
        
        Assert.Fail("Null exception should be thrown");
    }

    [Test]
    public void TestValids()
    {
        
        foreach (string str in _valid)
        {
            Assert.That(_v!.IsValid(str), Is.True, str + " is Valid but marked Invalid");
        }
        
        Assert.Pass();
    }
    
    [Test]
    public void TestInvalids()
    {
        foreach (string str in _invalid)
        {
            Assert.That(_v!.IsValid(str), Is.False, str + " is Invalid but marked Valid");
        }
        
        Assert.Pass();
    }
}