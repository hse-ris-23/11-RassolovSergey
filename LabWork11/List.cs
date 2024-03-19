using ClassLibraryLab10;
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
        int capacity; // Выделенное количество памяти под массив (с запасом)
        int count; // Реальное количество объектов в массиве

        // Свойства Capacity
        public int Capacity
        {
            get => capacity; // Возвращаем выделенное количество памяти
            private set => capacity = value; // Возможность установки значения длины
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

        // Метод добавления 1 элемента в массив (При необходимости увеличиваем длину массива в 2 раза)
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

        // Метод удаления элемента по индексу
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count) { throw new ArgumentOutOfRangeException(); }

            for (int i = index; i < Count - 1; i++)
            {
                list[i] = list[i + 1];
            }

            list[Count - 1] = default(T);
            count--;
        }

        // Метод клонирования списка
        public List<T> Clone()
        {
            List<T> clonedList = new List<T>();
            for (int i = 0; i < Count; i++)
            {
                clonedList.Add(this[i]);
            }
            return clonedList;
        }

        // Метод сортировки списка
        public void Sort()
        {
            Array.Sort(list, 0, Count);
        }

        // Метод поиска элемента в списке
        public int Find(T item)
        {
            return Array.IndexOf(list, item, 0, Count);
        }
    }
}

