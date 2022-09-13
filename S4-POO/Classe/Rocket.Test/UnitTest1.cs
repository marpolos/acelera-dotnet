using FluentAssertions;

namespace Rocket.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Rocket trybeRocket = new ();
        trybeRocket.Should().NotBeNull();
        trybeRocket.Should().BeOfType<Rocket>();
    }

    [Fact]
    public void Test2()
    {
        Rocket trybeRocket = new ("Decola", 150);
        trybeRocket.Name.Should().Be("Decola");
        trybeRocket.Price.Should().Be(150);
    }
}

