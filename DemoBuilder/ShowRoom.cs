using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBuilder
{
    public class ShowRoom
    {
        private MonitorBuilder monitor;
        private CaseBuilder casebd;

        public ShowRoom()
        {
            monitor = new MonitorBuilder();
            casebd = new CaseBuilder();
        }

        public Computer BuildComputer()
        {
            // process to build computer
            // 1. build monitor
            Computer c = new Computer();
            monitor.Build(c);
            // 2. build case
            casebd.Build(c);

            return c;
        }
    }
}