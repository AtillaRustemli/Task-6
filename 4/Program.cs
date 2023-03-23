namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerini coxdan aza dogru siralamaq*/


            int c, n;
           
        l1:
            Console.Write("Ededi daxil edin: ");
            if (!int.TryParse(Console.ReadLine(), out c))
            {
                goto l1;

            }
        l2:
            Console.Write("Massivin elementlerinin sayini qeyd edin: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                goto l2;

            }
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
            l3:
                Console.Write($"{i + 1}-ci element: ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                    goto l3;
              
                if (numbers[i] <= c)
                {
                    if (i + 1 == n && numbers[i] <= c)
                    {
                        numbers[i] = 0;
                        break;
                    }
                    if (i +1== n&& numbers[i] <= c)
                    {
                        break;
                    }
                    
                    numbers[i] = numbers[i + 1];
                    
                    
                }


            }
                           Array.Sort(numbers);
            Array.Reverse(numbers);


            for (int i = 0; i < n; i++)
            {
                

                if (numbers[i] == 0)
                {
                    continue;
                }
                
                Console.Write($".{numbers[i]}.");
            }

        }
    }
}