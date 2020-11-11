using System;
using Loupedeck;

namespace TestPlugin
{
    public class AfterEffectsApplication : ClientApplication
    {
        protected override string GetProcessName() => "Notepad";

        protected override string GetBundleName() => string.Empty;

        public override void Activate()
        {
            base.Activate();
        }

        public override void Start()
        {
            base.Start();
        }
    }
}
