namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* X(n) massivinden ancaq menfi elementlerin maximum elementi tapin*/

            int n,k=0;
            l1:
            Console.Write("Massivin elementlerinin sayini qeyd edin: ");
            if (!int.TryParse(Console.ReadLine(), out n)) {
                goto l1;
            }
            int[] numbers=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Massivin {i + 1}-ci elementini qeyd edin: ");
            l2:
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    goto l2;
                }
            }
                Array.Sort(numbers);
                for (int i = 0; i < n; i++)
                {
                    if (numbers[i] < 0)
                    {
                        k = numbers[i];
                    
                    }
                }
                if(k!=0)
            {
                Console.WriteLine($"Menfi elementlerin en boyuyu: {k}");
            }
            else
            {
                Console.WriteLine("Menfi eded yoxdur!");
            }


            

        }
    }
}