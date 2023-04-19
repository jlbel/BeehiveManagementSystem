using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    abstract class Bee
    {
        public string Job { get; private set; } // каждый класс передает свою работу с пом-ю конструктора
       protected virtual float CostPerShift { get; private set; } // позволяет каждому субклассу Bee определить количество меда, потребляемого им за смену

        public Bee(string job)
        {
            Job = job;
        }

       protected void WorkTheNextShif(Bee worker)
        {
            bool c = HoneyVault.ConsumeHoney(HoneyConsumed);
            if (c == true) DoJob(); 
        }
        protected virtual DoJob() { }

    }
}
