using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkInterface
{    /*Задание 1
Создайте интерфейс IOutput. В нём должно быть два метода:

void Show() — отображает информацию;
void Show(string info) — отображает информацию и информационное сообщение, которое было указано в параметре info.
Создайте класс Array (массив целого типа) с необходимыми методами. Этот класс должен имплементировать интерфейс IOutput.

Метод Show() — отображает на экран элементы массива.

Метод Show(string info) — отображает на экран элементы массива и информационное сообщение, указанное в параметре info.

Напишите код для тестирования полученной функциональности.*/
    internal class Array : IOutput
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

    }
}
