using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc("2,3,6,5,45,2,65,34,7,6,5", "+,/,-,*,+");

            SerializationData serializationData = new SerializationData();
            serializationData.SaveData(calc);

            calc.StringSplit();

            Console.ReadKey();
        }
    }
}
