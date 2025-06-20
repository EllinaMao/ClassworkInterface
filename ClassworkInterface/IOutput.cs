using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkInterface
{
    /*Задание 1
Создайте интерфейс IOutput. В нём должно быть два метода:

void Show() — отображает информацию;
void Show(string info) — отображает информацию и информационное сообщение, которое было указано в параметре info.
*/
    internal interface IOutput
    {
        void Show();//отображает информацию;
        void Show(string info);//отображает информацию и информационное сообщение, которое было указано в параметре info.

    }
}
