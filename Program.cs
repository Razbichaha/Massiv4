using System;

namespace Massiv4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое число и я его запомню\nвведите sum - сложение введеных чисел\nвведите exit - закрытие программы\n");

            bool stopPrormam = true;
            string inputString = Console.ReadLine();
            int[] number = new int[0];
            int iteration = 0;

            while(stopPrormam)
            {

                switch(inputString)
                {
                    case "sum":
                        inputString = "0" + "";
                        int sum = 0;

                        foreach(int i in number)
                        {
                            sum += i;
                        }

                        Console.WriteLine("Сумма набранных чисел = "+sum);

                        break;
                    case "exit":

                        stopPrormam = false;

                        break;
                    default:

                        int[] temp = new int[number.Length + 1];
                        int tmp = 0;

                        foreach(int i in number)
                        {
                            temp[tmp] = i;
                            tmp++;
                        }
                        
                        number = temp;
                        number[iteration] = Convert.ToInt32( inputString);
                        iteration++;

                        break;
                } 
                inputString = Console.ReadLine();
            }
        }
    }
}
