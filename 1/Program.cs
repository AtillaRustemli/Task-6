namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, n;
            l1:
            Console.Write("Ededi daxil edin: ");
            if(!int.TryParse(Console.ReadLine(), out c) )
            {
                goto l1;

            }
        l2:
            Console.Write("Massivin elementlerinin sayini qeyd edin: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                goto l2;

            }

            int[] numbers=new int[n];
            int[] newNumbers = new int[n];

            
             for (int i = 0; i <n; i++)
            {
            l3:
                Console.Write($"{i + 1}-ci element: ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                    goto l3;
                
               
                }


            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < c)
                {
                    Console.WriteLine(numbers[i]); 
                }
            }
           
            
            
        }
    }
}