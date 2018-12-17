using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace CalcDelegate
{
    class SerializationData
    {
        DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(Calc));

        public Calc LoadData()
        {
            using (FileStream fs = new FileStream("calc.txt", FileMode.OpenOrCreate))
            {
                Calc calc = (Calc)data.ReadObject(fs);
                return calc;
            }
        }

        public void SaveData(Calc calc)
        {
            using (FileStream fs = new FileStream("calc.txt", FileMode.Create))
            {
                data.WriteObject(fs, calc);
            }
        }
    }
}
