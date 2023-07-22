
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int x = 1;


            MyList<String> list = new MyList<String>();

            while (x != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the function execution code(1, 2, 3, 4, 5), otherwise enter zero to exit the program:");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1: AddElement(list); break;

                    case 2: RemoveAtElement(list); break;

                    case 3: RemoveElement(list); break;

                    case 4: ClearList(list); break;

                    case 5: SortElement(list); break;
                }

            }
        }

        private static void AddElement(MyList<string> list)
        {
            Console.WriteLine("Enter how many elements to insert into the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string userInput;
                Console.WriteLine($"Entering element number {i} : ");
                userInput = Console.ReadLine();
                list.Add(userInput);
            }

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }
        }

        static void RemoveAtElement(MyList<string> list)
        {
            Console.WriteLine($"Enter the index of the element to be removed: ");
            int n = Convert.ToInt32(Console.ReadLine());
            list.RemoveAt(n);

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }

        }

        static void RemoveElement(MyList<string> list)
        {
            Console.WriteLine($"Enter the element to be removed: ");
            string n = Convert.ToString(Console.ReadLine());
            list.Remove(n);

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }

        }

        static void ClearList(MyList<string> list)
        {
            list.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }
        }

        static void SortElement(MyList<string> list)
        {
            list.SortElement();

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }
        }

        /*
         
        static void AddRange(List<string> starList)
        {
            Random random = new Random();
            string[] randomTarget = new string[8] { "Venitate", "Vega", "Mircam", "Talina", "Vita", "Isida", "Hedus", " Maara" };

            Console.WriteLine("Enter the dimension of the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] targetArray = new string[n];
            for (int i = 0; i < targetArray.Length; i++)
            {
                targetArray[i] = (randomTarget[random.Next(randomTarget.Length)]);
                Console.WriteLine($" A [ {i} ] = {targetArray[i]} ");
            }

            starList.AddRange(targetArray);

        }

        */
    }
}