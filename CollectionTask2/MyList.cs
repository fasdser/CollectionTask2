using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CollectionTask2
{
    public interface IMyList<T>
    {
        void Add(T item);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }

    class MyList<T>:IMyList<T>
    {
        private T[] items;

        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] array = new T[items.Length+1];
            for (int i = 0; i < items.Length; i++)
            {
                array[i] = items[i];
            }
            array[items.Length] = item;
            items = array;
        }

        public T this[int index]
        {
            get { return items[index]; }
        }

        public int Count
        {
            get { return items.Length; }
        }
        public void Clear()
        {
            items = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((int)(object)items[i] == (int)(object)item)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < items.Length; i++)
            {
                str += items[i] + " ";
            }
            return "Размерность массива " + items.Length + " Элемент массива:" + str; 
        }

        int position = -1;

        public void Reset()
        {
            position = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < items.Length - 1)
                {
                    position++;
                    yield return items[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
    }
}
