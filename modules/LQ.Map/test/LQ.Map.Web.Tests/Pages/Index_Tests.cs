using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LQ.Map.Pages;

public class Index_Tests : MapWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
