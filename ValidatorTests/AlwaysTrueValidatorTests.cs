namespace ValidatorTests;

public class AlwaysTrueValidatorTests
{
    
    // note, this validator allows all passwords except null
    private readonly string[] _valid = {
        "P@ssword123",
        "!2Sh0rT^",
        "3chartypeS",
        "3chartype$",
        "ONECHARTYPEBUTLONG",
        "onchartypebutlong",
        "00000000000000000",
        "'`~!@#$%^&*()-=_+/?{|}",
        "2Sh0rT",
        "onechartype",
        "ONECHARTYPE",
        "123456789",
        "'`~=_+/?{|}",
        "2cchartypes",
        "2CHARCTYPES",
        "WhiteSp !2",
        ""
    };
    
    private Validator.AlwaysTrueValidator? _v;

    [SetUp]
    public void Setup()
    {
        _v = new Validator.AlwaysTrueValidator();
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
    public void TestAll()
    {
        foreach (string str in _valid)
        {
            Assert.That(_v!.IsValid(str), Is.True, str + " is Valid but marked Invalid");
        }
        
        Assert.Pass();
    }

}