using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BeehiveManagementSystem
{
    class Queen : Bee
    {
        public Queen() : base("Queen")
        {
            AssignBee("EggCare");
            AssignBee("NectarCollector");
            AssignBee("HoneyManufacturer");
        }
        protected override float CostPerShift { get { return 2.15f; } }
        private float eggs;
        private float unassignedWorkers;
        private Bee[] workers;
        const float EGGS_PER_SHIFT = 0.54f;
        const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;

        /// <summary>
        /// Расширяет массив workers на один элемент и добавляет ссылку Bee.
        /// </summary>
        /// <param name="worker"></param>
        private void AddWorker(Bee worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }
        public void AssignBee(string job)
        {
            switch (job)
            {
                case "EggCare": AddWorker(new EggCare());
                    break;
                case "NectarCollector": AddWorker(new NectarCollector());
                    break;
                case "HoneyManufacturer": AddWorker(new HoneyManufacturer());
                    break;
            }
        }
        protected override DoJob()
        {
            eggs += EGGS_PER_SHIFT;
            foreach (Bee worker in workers) WorkTheNextShif(worker);
            HoneyVault.ConsumeHoney(HONEY_PER_UNASSIGNED_WORKER * workers.Length);
        }
        /// <summary>
        /// Вылупляем из яиц муравьев епта
        /// </summary>
        /// <param name="eggsToConvert"></param>
        public void CareForEggs (float eggsToConvert)
        {
            if (eggs >= eggsToConvert) unassignedWorkers+= eggs-= eggsToConvert;
        }
    }
}



