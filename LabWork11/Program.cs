using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLab10;

namespace LabWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты из библиотеки классов 10 ЛР
            Card card1 = new Card();
            card1.RandomInit();
            DebitCard dCard1 = new DebitCard();
            dCard1.RandomInit();
            JunCard jCard1 = new JunCard();
            jCard1.RandomInit();
            CreditCard creditCard1 = new CreditCard();
            creditCard1.RandomInit();


            //  Создаем объект класса List и записываем туда объекты
            List<Card> list1 = new List<Card>(card1, dCard1, jCard1, creditCard1);


            // Выводим объекты из списка - List
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }

            // Выводим информацию об кол-во объектов
            Console.WriteLine($"Ёмкость = {list1.Capacity}");
            Console.WriteLine($"Кол-во элементов = {list1.Count}");
            Console.WriteLine();

            // Создаем новые объекты из библиотеки классов 10 ЛР
            CreditCard creditCard2 = new CreditCard();
            creditCard2.RandomInit();
            list1.Add(creditCard2);


            // Выводим объекты из списка - List
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }

            // Выводим информацию об кол-во объектов
            Console.WriteLine($"Ёмкость = {list1.Capacity}");
            Console.WriteLine($"Кол-во элементов = {list1.Count}");
            Console.WriteLine();
        }
    }
}
