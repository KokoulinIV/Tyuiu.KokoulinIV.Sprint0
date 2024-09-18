using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KokoulinIV.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] number)
            
        {
            var total = 0;
            for (var i = 0; i < number.Length; i++)
            {
                total = total + number[i];
            }
            return total;
        }
        
        public static int SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }
        public static int MultiplicationArray(int[] number)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * number[index];
                index++;
            }
            while (index < number.Length);
            return total;
        }
    }
}
