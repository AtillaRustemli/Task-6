namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*a massivinin (a[0],a[1] .... a[n]) en kicik ve en boyuk elementlerinin hendesi ve ededi ortasini tapmali*/


            int n;
            int k = 0, x = 0;
            l1:
            Console.Write("Massivin elementlerinin sayini qeyd edin: ");
            if (!int.TryParse(Console.ReadLine(), out n)) {

                goto l1;
            
            }
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                l2:
                Console.Write($"Massivin {i+1}- ci elementi: ");
                if(!int.TryParse(Console.ReadLine(),out numbers[i]))
                {
                    goto l2;
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < n; i++)
            {
                k = numbers[i];
            }
            Array.Reverse(numbers);
            for (int i = 0; i < n; i++)
            {
                x = numbers[i];
  
            }
               

            double hendesi=Math.Sqrt(k*x);
            double ededi=(k+x)/2;
            Console.WriteLine($"Massivin en kicik ve en boyuk elementlerinin hendesi ortasi : {hendesi}");
            Console.WriteLine($"Massivin en kicik ve en boyuk elementlerinin ededi ortasi : {ededi}");
            

        }
    }
}