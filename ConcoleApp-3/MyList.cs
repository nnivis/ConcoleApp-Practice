

namespace ConsoleApp3
{
    public class MyList<T>
    {
        private T[] array = new T[1];

        int count = 0; 
        public int Count { get => count; }

        int entryPosition = -1; 

        public void Print(int index)
        {
            Console.Write(array[index]);       
            Console.Write(" , ");
        }

        int _position = 0;

        public void Add(T item)
        {
            count++;
            Array.Resize(ref this.array, count);
            entryPosition++;
            this.array[entryPosition] = item; 
        }

        public void RemoveAt( int item)
        {
            bool target = false;

            if (item < count)
            {
                for (int i = item; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                    target = true;
                }
            }
            else Console.WriteLine("Index is out of list");

            if (target)
            {
                Array.Resize(ref array, count - 1);
                count--;
                entryPosition--;
            }

        }

        public void Remove(T item )
        {
            bool target = false;

            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    array[i] = array[i + 1];
                    target = true;
                }                             
            }

            if (target)
            {
                Array.Resize(ref array, count - 1);
                count--;
                entryPosition--;
            }
        }

        public void Clear()
        {
            array = new T[count];

            count = 0;
            entryPosition = -1;
        }

        public void SortElement()
        {
            Array.Sort(array);

        }

        public void AddRange(T item)
        {

        }

    }
}
