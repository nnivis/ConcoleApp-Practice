namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int x = 1;
            int[] result;

            Console.WriteLine("Enter the dimension of the array :");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.WriteLine($" A [ {i} ] = {array[i]} ");
            }

            while (x != 0)
            {

                Console.WriteLine("Enter the function code to execute (1, 2, 3), if you want to end the program enter 0:");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1: BubbleSort(array); break;

                    case 2:ShakerSort(array); break;

                    case 3: InsertionSort(array); break;
                }
            }

        }

        public static void Print(int[] array)
        {
            for(int i = 0; i < array.Length;i++)
            {
                Console.WriteLine($" A [ {i} ] = {array[i]} ");
            }
        }

        public static void Swap(ref int firstTraget, ref int secindTarget)
        {

            int temp = firstTraget;

            firstTraget = secindTarget;
            secindTarget = temp;
        }

        public static void BubbleSort(int[] array) // Insertion sort. Cost: O(1)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            Console.WriteLine();
            
            Print(array);
        }

        static void ShakerSort(int[] array) // Insertion sort. Cost: O(1)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                bool target = false;

                for (int j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        target = true;
                    }
                }

                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        target = true;
                    }
                }

                if (!target)
                {
                    break;
                }
            }

            Print(array);

        }

        static void InsertionSort(int[] array) // Insertion sort. Costs: O(n) main, O(1) additional        {
            for (int i = 1; i < array.Length; i++)
            {
                int value = array[i];

                bool target = false;

                for (int j = i - 1; j >= 0 && target != true;)
                {
                    if (value < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = value;
                    }
                    else target = true;
                }
            }

            Console.WriteLine();

            Print(array);
        }
    }
}