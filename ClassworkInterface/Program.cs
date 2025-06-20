using Task2;

namespace ClassworkInterface
{
    /*Задание 1
Создайте интерфейс IOutput. В нём должно быть два метода:

void Show() — отображает информацию;
void Show(string info) — отображает информацию и информационное сообщение, которое было указано в параметре info.
Создайте класс Array (массив целого типа) с необходимыми методами. Этот класс должен имплементировать интерфейс IOutput.

Метод Show() — отображает на экран элементы массива.

Метод Show(string info) — отображает на экран элементы массива и информационное сообщение, указанное в параметре info.

Напишите код для тестирования полученной функциональности.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            Array array = new Array(size);
            IMath math = array; 
            array.Show(); // Отображает элементы массива без сообщения
            array.Show(array.numbers.Length + " элементов в массиве. И носочки."); // Отображает элементы массива с сообщением

            Console.WriteLine("Максимум: " + math.Max()); // Выводит максимум
            Console.WriteLine("Минимум: " + math.Min()); // Выводит минимум
            Console.WriteLine("Среднее арифметическое: " + math.Avg()); // Выводит среднее арифметическое
            Console.WriteLine("Поиск 3: " + math.Search(3)); // Ищет значение 3 в массиве


        }
    }
}
