using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork11
{
    internal class List<T>
    {
        T[] list;
        int capacity; // Выделеное кол-во памяти под массив (С запасом)
        int count; // Реальное кол-во объектов в массиве

        // Свойства Capacity
        public int Capacity
        {
            get => list.Length; // Возвращаем размер массива
            private set => capacity = value; // Возможность установки значения длинны
        }



        // Считаем сколько реальных элементов в массиве
        public int Count { get => count; }



        // Конструктор без параметров (Создаем пустой массив)
        public List()
        {
            Capacity = 0;
            list = new T[Capacity];
        }


        // Конструктор - перезаписываем элементы в массив
        public List(params T[] list)
        {
            Capacity = list.Length;
            count = 0;
            this.list = new T[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                this.list[i] = list[i];
                count++;
            }
        }


        // Индексатор
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        // Метод добавления 1 элемента в массив (При необх. увеличиваем длинну массива в 2 раза)
        public void Add(T item)
        {
            if (item == null) { throw new ArgumentException(); }
            if (Count < Capacity)
            {
                list[count++] = item;
            }
            else
            {
                T[] temp = new T[Capacity * 2];
                for (int i = 0; i < list.Length; i++)
                {
                    temp[i] = list[i];
                }
                temp[count++] = item;
                list = temp;
            }
        }
    }
}
