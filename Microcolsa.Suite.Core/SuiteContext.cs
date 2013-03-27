using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcolsa.Suite.Core
{
    public static class SuiteContext
    {
        public static SuiteEntities Context { get; private set; }

        static SuiteContext()
        {
            Context = new SuiteEntities();
        }
    }
}
