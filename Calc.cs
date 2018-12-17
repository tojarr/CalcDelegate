using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalcDelegate
{
    [DataContract]
    class Calc
    {
        [DataMember]
        string _numbers;
        [DataMember]
        string _simbols;
        SerializationData serializationData = new SerializationData();
        delegate double OperationAll(string[] numbers);

        public Calc()
        {

        }
        public Calc(string numbers, string simbols)
        {
            _numbers = numbers;
            _simbols = simbols;
        }

        public void StringSplit()
        {
            Calc calc = serializationData.LoadData();
            ConsoleWriter("numbers: " + calc._numbers);
            ConsoleWriter("simbols: " + calc._simbols);
            ConsoleWriter("");
            string[] numbers = calc._numbers.Split(new char[] { ',' });
            string[] simbols = calc._simbols.Split(new char[] { ',' });

            OperationAll op1 = null;
            foreach (var simbol in simbols)
            {
                switch (simbol)
                {
                    case "+":
                        op1 += Sum;
                        break;
                    case "-":
                        op1 += Sub;
                        break;
                    case "/":
                        op1 += Div;
                        break;
                    case "*":
                        op1 += Mult;
                        break;
                    default:
                        ConsoleWriter("Invalid input.");
                        break;
                }
            }
            if (op1 != null)
                op1(numbers);
        }

        double Sum(string[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = 0;
                if(int.TryParse(numbers[i], out num))
                {
                    if(i == 0)
                    {
                        result = num;
                        Console.Write(result);
                    }
                    else
                    {
                        result = result + num;
                        Console.Write("+" + num);
                    }
                }
                else
                {
                    ConsoleWriter("Invalid input.");
                }
            }
            Console.Write("=" + result + "\n");
            return result;
        }

        double Sub(string[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = 0;
                if (int.TryParse(numbers[i], out num))
                {
                    if (i == 0)
                    {
                        result = num;
                        Console.Write(result);
                    }
                    else
                    {
                        result = result - num;
                        Console.Write("-" + num);
                    }
                }
                else
                {
                    ConsoleWriter("Invalid input.");
                }
            }
            Console.Write("=" + result + "\n");
            return result;
        }

        double Div(string[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = 0;
                if (int.TryParse(numbers[i], out num))
                {
                    if (i == 0)
                    {
                        result = num;
                        Console.Write(result);
                    }
                    else
                    {
                        result = result / num;
                        Console.Write("/" + num);
                    }
                }
                else
                {
                    ConsoleWriter("Invalid input.");
                }
            }
            Console.Write("=" + result + "\n");
            return result;
        }

        double Mult(string[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = 0;
                if (int.TryParse(numbers[i], out num))
                {
                    if (i == 0)
                    {
                        result = num;
                        Console.Write(result);
                    }
                    else
                    {
                        result = result * num;
                        Console.Write("*" + num);
                    }
                }
                else
                {
                    ConsoleWriter("Invalid input.");
                }
            }
            Console.Write("=" + result + "\n");
            return result;
        }

        void ConsoleWriter(string str)
        {
            Console.WriteLine(str);
        }
    }
}
