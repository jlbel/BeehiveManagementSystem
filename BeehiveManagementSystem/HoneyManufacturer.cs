using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class HoneyManufacturer : Bee
    {
        public HoneyManufacturer() : base("HoneyManufacturer") { }
        protected override DoJob() { }
        protected override float CostPerShift { get { return 1.7f; } }
    }
}
