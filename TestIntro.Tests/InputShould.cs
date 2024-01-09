namespace TestIntro.Tests;
using TestIntro.App;

public class InputShould
{
    [Fact]
    public void IsNameValid_InputIsGoliath_ReturnTrue()
    {
        Assert.True(Input.IsNameValid("Goliath"));
    }

    [Fact]
    public void IsNameValid_InputIsET_ReturnFalse()
    {
        Assert.False(Input.IsNameValid("ET"));
    }
}
