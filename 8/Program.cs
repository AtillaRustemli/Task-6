namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Heriri 14 elementli 2 massivin uygun elementlerini bir birine vurub?alinan musbet hasillerden  yeni massiv duzeltmeli*/
            int a = 0;
            int[] numbers1 = new int[14];
            int[] numbers2 = new int[14];
            for (int i = 0; i < 14; i++)
            {
                l1:
                Console.Write($"I massivin {i+1}-ci elementi: ");
                if(!int.TryParse(Console.ReadLine(),out numbers1[i]))
                {
                    goto l1;
                }
            }

            for (int i = 0; i < 14; i++)
            {
            l2:
                Console.Write($"II massivin {i + 1}-ci elementi: ");
                if (!int.TryParse(Console.ReadLine(), out numbers2[i]))
                {
                    goto l2;
                }

                if (numbers1[i] * numbers2[i] >= 0)
                {
                    a++;
                }
            }
            int[] numbers3 = new int[14];
        
            for (int i = 0; i < 14; i++)
            {
                
                if(numbers1[i] >0&& numbers2[i] > 0 || numbers1[i] < 0 && numbers2[i]<0)
                {
                    numbers3[i] = numbers1[i] * numbers2[i];
                }
                else 
                {
                    continue;
                }
                
                Console.WriteLine(numbers3[i]);
            }
            

        }
    }
}