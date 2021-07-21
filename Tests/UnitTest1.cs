using BlazorTest.Shared;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1 : TestContext
    {
        [Fact]
        public void IndexLoadsOK()
        {
            (Services as IServiceCollection).AddServices();

            var cut = RenderComponent<BlazorTest.Client.Pages.Index>();
            cut.MarkupMatches("Foo");
        }
    }
}
