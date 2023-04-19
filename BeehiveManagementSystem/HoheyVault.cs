using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        const float NECTAR_CONVERSION_RATIO = .19f; // Коэфф. конверсии нектара
        const float LOW_LEVEL_WARNING = 10f;        // Предупреждение о низком уровне
        private static float honey = 25f;
        private static float nectar = 100f;
        public static string StatusReport 
        { 
            get 
            {
                string status = $"{honey:0.0} units of honey + { nectar: 0.0} units of nectar";
                string warnings = "";
                if (honey < LOW_LEVEL_WARNING) warnings +="LOW HONEY - ADD A HONEY MANUFACTURER";
                if (nectar < LOW_LEVEL_WARNING) warnings += "LOW NECTAR - ADD A NECTAR MANUFACTURER";
                return status + warnings;
            }
        }

        /// <summary>
        /// Преобразует нектар в мед. д. Уменьшает поле nectar на указанную величину и увеличивает поле honey на величину amount × NECTAR_CONVERSION_RATIO
        /// </summary>
        /// <param name="amount"></param>
        static void ConvertNectarToHoney (float amount )
        {
            if (amount <= nectar)
            {
                nectar -= amount;
                honey = NECTAR_CONVERSION_RATIO * amount;
            }
            else
            {
                honey = NECTAR_CONVERSION_RATIO * nectar;
                nectar = 0;
            }
        }
       
        /// <summary>
        /// Метод получает параметр amount. Если значение параметра положительное, оно прибавляется к полю honey
        /// </summary>
        /// <param name="amount"></param>
        static void CollectNectar(float amount)
        {
            if (amount > 0) honey += amount;
        }
        
        /// <summary>
        /// определяет то, как пчелы потребляют мед для выполнения своих задач. Метод получает параметр amount.
        ///Если он меньше текущего содержимого поля honey, то метод вычитает amount из honey и возвращает true; в противном случае возвращается false
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static bool ConsumeHoney (float amount)
        {
            if (amount < honey)
            {
                honey -= amount;
                return true;
            }
            else return false; 
        }




    }
}
