﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Создайте интерфейс IMath. В нём должно быть четыре метода:

int Max() — возвращает максимум;
int Min() — возвращает минимум;
float Avg() — возвращает среднеарифметическое;
bool Search(int valueToSearch) — ищет valueSearch внутри контейнера данных. Возвращает true, если значение найдено. Возвращает false, если значение не найдено.
Класс, созданный в первом задании Array, должен имплементировать интерфейс IMath.

Метод Max — возвращает максимум среди элементов массива.

Метод Min — возвращает минимум среди элементов массива.

Метод Avg — возвращает среднеарифметическое среди элементов массива.

Метод Search — ищет значение внутри массива. Возвращает true, если значение найдено. Возвращает false, если значение не найдено.

Напишите код для тестирования полученной функциональности*/
    public interface IMath
    {
        int Max(); // возвращает максимум
        int Min(); // возвращает минимум;
        float Avg(); // возвращает среднеарифметическое
        bool Search(int valueToSearch);// ищет valueSearch внутри контейнера данных.Возвращает true, если значение найдено.Возвращает false, если значение не найдено.

    }
}
