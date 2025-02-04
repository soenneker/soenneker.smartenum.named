using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.SmartEnum.Named.Tests;

[Collection("Collection")]
public class NamedSmartEnumTests : FixturedUnitTest
{
    public NamedSmartEnumTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
