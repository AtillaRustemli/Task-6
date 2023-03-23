namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerinin hendesi ortasini tapmaq*/
            int c, n;
            int k = 1;
            double a = 0;
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


            }


            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > c)
                {
                    a++;
                    k *= numbers[i];
                   

                }
            }
            double t = 1 / a ;
            double s=Math.Pow(k,t);
            Console.WriteLine(s);
           
          

        }
    }
}