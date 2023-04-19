using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class NectarCollector : Bee
    {
        public NectarCollector() : base("NectarCollector") { }
        protected override DoJob() { }
        protected override float CostPerShift { get { return 1.95f; } }
    }
}
