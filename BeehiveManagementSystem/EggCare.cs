using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class EggCare : Bee
    {
        public EggCare() : base("EggCare") { }
        protected override DoJob() { }
        protected override float CostPerShift { get { return 1.35f; } }
    }
}
