using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace ClassworkInterface
{    /*Задание 1
Создайте интерфейс IOutput. В нём должно быть два метода:

void Show() — отображает информацию;
void Show(string info) — отображает информацию и информационное сообщение, которое было указано в параметре info.
Создайте класс Array (массив целого типа) с необходимыми методами. Этот класс должен имплементировать интерфейс IOutput.

Метод Show() — отображает на экран элементы массива.

Метод Show(string info) — отображает на экран элементы массива и информационное сообщение, указанное в параметре info.

Напишите код для тестирования полученной функциональности.
    
   task 2   
  Класс, созданный в первом задании Array, должен имплементировать интерфейс IMath.

Метод Max — возвращает максимум среди элементов массива.

Метод Min — возвращает минимум среди элементов массива.

Метод Avg — возвращает среднеарифметическое среди элементов массива.

Метод Search — ищет значение внутри массива. Возвращает true, если значение найдено. Возвращает false, если значение не найдено.    
      */
    public class Array : IOutput, IMath
    {
        public int[] numbers { get; set; }


        public Array(int[] arr)
        {
            numbers = arr;
        }

        public Array(int size)
        {
            numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = i + 1; 
            }
        }

        public void Show()
        {
        Console.WriteLine("Элементы массива:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Console.WriteLine("Элементы массива:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }

        int IMath.Max()
        {
            return numbers.Max();
        }

        int IMath.Min()
        {
            return numbers.Min();
        }

        float IMath.Avg()
        {
            return (float)numbers.Average();
        }
        bool IMath.Search(int valueToSearch)
        {
            return numbers.Contains(valueToSearch);
        }
    }
}
