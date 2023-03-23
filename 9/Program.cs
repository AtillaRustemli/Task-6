namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 25 elementli massivin ilk 8 elementini kvadrata yukseltmeli,qalanini ise 4-e bolub,yeni iki massiv duzeltmeli*/

            int[] numbers1 = new int[25];
            int[] numbers2 = new int[8];
            int[] numbers3 = new int[25];
           

            for (int i = 0; i < 25; i++)
            {
                l1:
                Console.Write($"Esas massivin {i+1}-ci elementi: ");
                if(!int.TryParse(Console.ReadLine(),out numbers1[i]))
                {
                    goto l1;

                }
            }

            for (int i = 0; i < 8; i++)
            {
                
               
                numbers2[i] = numbers1[i] * numbers1[i];
              
            }


            Console.WriteLine($"I massivin elementleri: ");
            for (int i = 0; i < 8; i++)
            {
                 Console.WriteLine($"{i+1}-ci {numbers2[i]}.");
            }


            for (int i = 8; i < 25; i++)
            {
                
                Console.WriteLine($"II massivin {i+1}-ci elementi");
                numbers3[i] = numbers1[i] / 4;
               
            }

            Console.WriteLine($"II massivin elementleri: ");
            for (int i = 8; i < 25; i++)
            {
                
                Console.WriteLine($" {i + 1}-ci {numbers3[i]}");
               
            }
        }
    }
}