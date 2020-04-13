/*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока.
Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 
*/
using System;

namespace Taks4
{
    static class ExtensionClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] _arrayInExtensionClass = new T[list.TotalNumberOfElements];

            for (int i = 0; i < list.TotalNumberOfElements; i++)
                _arrayInExtensionClass[i] = list[i];
            return _arrayInExtensionClass;
        }
    }

    class MyList<T>
    {
        T[] _array;
        int _counter;

        public MyList(int numberOfArrayElements)
        {
            _array = new T[numberOfArrayElements];
        }

        //свойство TotalNumberOfElements на чтение, для получения общего количества элементов
        public int TotalNumberOfElements => _array.Length;

        //Индексатор для получения значения элемента по указанному индексу
        public T this[int index] => _array[index];

        //метод AddItem для добавления элемента
        public void AddItem(T element)
        {
            _array[_counter] = element;
            _counter++;
        }
    }

    class Program
    {
        static MyList<int> instance;
        static int numberOfArrayElements;
        static int[] array;

        static void Main(string[] args)
        {
            numberOfArrayElements = new Random().Next(10, 20);

            instance = new MyList<int>(numberOfArrayElements);

            Console.WriteLine($"Количество элементов массива = {TotalNumberOfArrayElements()}");

            //Расширяющий метод GetArray, который использует свойство TotalNumberOfElements экземпляра класса instance, и возвращает массив элементов
            array = instance.GetArray<int>();

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"array[{i + 1}] = {array[i]}");

            //Передаем рандомные элементы, по одному, в метод AddItem.
            int TotalNumberOfArrayElements()
            {
                for (int i = 0; i < numberOfArrayElements; i++)
                    instance.AddItem(new Random().Next(100));

                return instance.TotalNumberOfElements;
            }

            Console.ReadKey();
        }
    }
}
