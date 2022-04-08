using System;

namespace Massiv4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое число и я его запомню\nвведите sum - сложение введеных чисел\nвведите exit - закрытие программы\n");

            bool continueCycle = true;
            int[] numbers = new int[0];
           
            while(continueCycle)
            {
                string inputString = Console.ReadLine();

                switch(inputString)
                {
                    case "sum":

                        int sum = 0;

                        foreach(int i in numbers)
                        {
                            sum += i;
                        }

                        Console.WriteLine("Сумма набранных чисел = "+sum);

                        break;
                    case "exit":

                        continueCycle = false;

                        break;
                    default:

                        int[] temp = new int[numbers.Length + 1];

                        for (int i= 0;i < numbers.Length;i++)
                        {
                            temp[i] = numbers[i];
                        }
                        
                        numbers = temp;
                        numbers[numbers.Length-1] = Convert.ToInt32( inputString);

                        break;
                } 
            }
        }
    }
}
