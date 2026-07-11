using Soenneker.Tests.HostedUnit;

namespace Soenneker.Monday.Runners.GraphQlClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class MondayGraphQlClientRunnerTests : HostedUnitTest
{
    public MondayGraphQlClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
