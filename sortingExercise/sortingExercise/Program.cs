namespace sortingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("practicing bubble sorts..!");
            //create 2 int arrays w/ same content
            int[] array1 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int[] array2 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

            //print out content of array1 before sort
            Console.WriteLine("content of array1:" );
            for (int i =0; i< array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            //sort first array w handmade bubble sort method
            StudentBubbleSort(array1);

            //print updated array1
            Console.WriteLine("array1 after implementing handmade bubble sort: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            //print array2 content
            Console.WriteLine("content of array2: ");
            for (int i =0; i<array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            //use built-in C# Sort 
            Array.Sort(array2);

            //print updated array2
            Console.WriteLine("array2 after sorting with built-in C# .Sort: ");
            for (int i = 0; i<array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

        }

        /*
         * StudentBubbleSort: created bubble sort- compare a[j] and a[j+1], if
         * j > j+1, then switch theit order in the array. loop this until all 
         * items have been sorted appropriately
         */
        static void StudentBubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++) {
                bool isAnyChange = false;

                //goes through all array items
                for (int j  = 0; j<a.Length-1; j ++)
                {
                    if (a[j] > a[j + 1])
                    {
                        isAnyChange = true;

                        //swap to put items in order
                        (a[j], a[j + 1]) = (a[j + 1], a[j]);
                    }
                }

                if (!isAnyChange) { break; }
            }
        }
    }
}
