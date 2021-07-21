using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.Shared
{
    public class ScopedService : IScopedService
    {
        public string Text => "Foo";
    }

    public interface IScopedService
    {
        public string Text { get; }
    }
}
