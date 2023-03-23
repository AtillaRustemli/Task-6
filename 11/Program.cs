namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*X(n) massivinin elementlerini random olaraq 0-100 arasi ededlerle doldurub,sonra ise azalma sirasina gore duzmeli*/

            int n;
            l1:
            Console.Write("Massivin elementlerinin sayini qeyd edin: ");
            if(!int.TryParse(Console.ReadLine(),out n))
            {
                goto l1;
            }

            int[] numbers = new int[n];
            int num;
            Random random = new Random();
            
            for (int i = 0; i < n; i++)
            {
                num = random.Next(1, 100);
                Console.Write("MAssivin {i+1}-ci elementi: ");
                numbers[i] = num;
                Console.WriteLine(numbers[i]);
            }
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine("Alinan massivin azalma sirasi ile duzulmush formasi");
            for (int i = 0; i < n; i++)
            {
            Console.Write($"..{numbers[i]}..");
            }
            


        }
    }
}

            //Console.WriteLine(num);