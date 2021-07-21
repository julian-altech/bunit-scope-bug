using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.Shared
{
    public class SingletonService : ISingletonService
    {
        private IScopedService _scopedService;
        public SingletonService(IScopedService scopedService) =>
            _scopedService = scopedService;

        public IScopedService ScopedService => _scopedService;
    }

    public interface ISingletonService
    {
        public IScopedService ScopedService { get; }
    }
}
