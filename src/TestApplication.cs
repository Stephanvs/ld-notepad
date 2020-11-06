using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loupedeck;

namespace TestPlugin
{
    public class TestApplication : ClientApplication
    {
        protected override string GetProcessName() => "Notepad";

        protected override string GetBundleName() => string.Empty;
    }
}
